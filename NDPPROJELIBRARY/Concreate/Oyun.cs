/****************************************************************************
** SAKARYA ÜNİVERSİTESİ
** BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
** BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
** NESNEYE DAYALI PROGRAMLAMA DERSİ
** 2021-2022 BAHAR DÖNEMİ
**
** ÖĞRENCİ ADI............:Aysu ATICIOĞLU
** ÖĞRENCİ NUMARASI.......:B211200305
** DERSİN ALINDIĞI GRUP...:B
****************************************************************************/

using NDPPROJELIBRARY.Enum;
using NDPPROJELIBRARY.Interface;
using System.Collections.Generic;
using System.Windows.Forms;
using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;

namespace NDPPROJELIBRARY.Concreate
{
    public class Oyun : IOyun
    {

        SqlConnection baglan = new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ToString());
        SqlCommand komut;
        public int oyuncuID;
        public string oyuncuIsım;
        public int oyuncuToplam;
        public int oyuncuSure;
        public int oyuncuKalan;
        public int oyuncuSkor;
        SqlDataReader data;
        public bool dondur = false;
        public string sonucMetin = "";
        public bool bittiMi = false;
        #region Alanlar
        //Timerlar oluşturuldu.
        private readonly Timer _gecensureTimer = new Timer { Interval = 1000 };
        private readonly Timer _hareketTimer = new Timer { Interval = 100 };
        private readonly Timer _fareOlusturTimer = new Timer { Interval = 1000 };
        private readonly Timer _yumakOlusturTimer = new Timer { Interval = 3000 };
        private readonly Timer _mamaOlusturTimer = new Timer { Interval = 5000 };
        private readonly Timer _uzumOlusturTimer = new Timer { Interval = 7000 };
        private readonly Timer _cikolataOlusturTimer = new Timer { Interval = 9000 };
        private readonly Timer _kutuOlusturTimer = new Timer { Interval = 10000 };

        public int yumaksayisi = 1;//Yumaktan 1 tane toplaması gerekiyor.
        public int faresayisi = 2; //Fareden 2 tane gerekiyor. 
        public int mamasayisi = 3; //Mamadan 3 tane toplaması gerekiyor.
        public bool skorZarar = false;

        bool DurdurulduMu;
        public bool Degistir = false;
        private TimeSpan _gecenSure;

        private readonly Panel _oyunAlaniPanel;

        private Kedi _kedi;
        private readonly List<Fare> _fareler = new List<Fare>();
        private readonly List<Yumak> _yumaklar = new List<Yumak>();
        private readonly List<Mama> _mamalar = new List<Mama>();
        private readonly List<Cikolata> _cikolatalar = new List<Cikolata>();
        private readonly List<Uzum> _uzumler = new List<Uzum>();
        private readonly List<Kutu> _kutular = new List<Kutu>();

        #endregion
        #region Olaylar
        public event EventHandler GecensureDegisti;


        #endregion
        #region Ozellikler
        public bool DevamEdiyor { get; private set; }

        public TimeSpan GecenSure
        {
            get => _gecenSure;
            private set
            {
                _gecenSure = value;
                GecensureDegisti?.Invoke(this, EventArgs.Empty);


            }
        }



        #endregion
        #region Metotlar

        public Oyun(Panel oyunAlaniPanel)//Tekrar edenler
        {

            _oyunAlaniPanel = oyunAlaniPanel;
            _gecensureTimer.Tick += GecenSureTimer_Tick;
            _hareketTimer.Tick += HareketTimer_Tick;
            _fareOlusturTimer.Tick += FareOlusturmaTimer_Tick;
            _yumakOlusturTimer.Tick += YumakOlusturmaTimer_Tick;
            _mamaOlusturTimer.Tick += MamaOlusturmaTimer_Tick;
            _uzumOlusturTimer.Tick += UzumOlusturmaTimer_Tick;
            _cikolataOlusturTimer.Tick += CikolataOlusturmaTimer_Tick;

            _kutuOlusturTimer.Tick += KutuOlusturmaTimer_Tick;



        }
        private void HareketTimer_Tick(object sender, EventArgs e)
        {

            FareleriHareketEttir();
            YumaklariHareketEttir();
            MamalariHareketEttir();
            KutulariHareketEttir();
            CikolatalariHareketEttir();
            UzumleriHareketEttir();
            Topla();


        }
        //Oluşturulan ürünlerin hareket metotları
        private void FareleriHareketEttir()
        {
            foreach (var fare in _fareler)
            {
                var carptiMi = fare.HareketEttir(Yon.Asagi);//Farelerin aşagı düşmesi
                if (!carptiMi)//Eğer fareler çarpmadıysa yeni fareler oluşturulacak
                {
                    continue;
                }

                // Bitir();break;
            }
        }
        private void UzumleriHareketEttir()
        {
            foreach (var uzum in _uzumler)
            {
                var carptiMi = uzum.HareketEttir(Yon.Asagi);//Farelerin aşagı düşmesi
                if (!carptiMi)//Eğer fareler çarpmadıysa yeni fareler oluşturulacak
                {
                    continue;
                }

                // Bitir();break;
            }
        }
        private void CikolatalariHareketEttir()
        {
            foreach (var cikolata in _cikolatalar)
            {
                var carptiMi = cikolata.HareketEttir(Yon.Asagi);//Farelerin aşagı düşmesi
                if (!carptiMi)//Eğer fareler çarpmadıysa yeni fareler oluşturulacak
                {
                    continue;
                }

                // Bitir();break;
            }
        }
        private void KutulariHareketEttir()
        {
            foreach (var kutu in _kutular)
            {
                var carptiMi = kutu.HareketEttir(Yon.Asagi);//Farelerin aşagı düşmesi
                if (!carptiMi)//Eğer fareler çarpmadıysa yeni fareler oluşturulacak
                {
                    continue;
                }

                // Bitir();break;
            }
        }
        private void YumaklariHareketEttir()
        {

            foreach (var yumak in _yumaklar)
            {

                var carptiMi = yumak.HareketEttir(Yon.Asagi);//Farelerin aşagı düşmesi
                if (!carptiMi)//Eğer fareler çarpmadıysa yeni fareler oluşturulacak
                {
                    continue;
                }

                //Bitir();break;
            }



        }
        private void MamalariHareketEttir()
        {
            foreach (var mama in _mamalar)
            {
                var carptiMi = mama.HareketEttir(Yon.Asagi);//Farelerin aşagı düşmesi
                if (!carptiMi)//Eğer fareler çarpmadıysa yeni fareler oluşturulacak
                {
                    continue;
                }

                // Bitir();break;
            }
        }


        //Toplanan nesnelerin işlemleri
        private void Topla()
        {

            for (var i = _yumaklar.Count - 1; i >= 0; i--)
            {
                var yumak = _yumaklar[i];
                var topladiMi = yumak.TopladiMi(_kedi);
                if (!topladiMi)
                {//Eğer toplanmadıysa
                    if (_yumaklar[i].Bottom == _oyunAlaniPanel.Bottom)//ve panelinin en altındaysa
                    {
                        _oyunAlaniPanel.Controls.Remove(yumak);//nesneyi sil
                    }
                    else { continue; }//Yoksa devam et

                }


                if (topladiMi)//Eğer kedi topladıysa
                {


                    if (yumaksayisi == 0) yumaksayisi = 0;
                    else
                    {
                        yumaksayisi--;//Yumak toplandıysa sayısından eksilt.
                        oyuncuSkor += 10;//Skora puan ekle
                        Degistir = true;//Toplananları ekrana anında yazmak için
                    }

                    _yumaklar.Remove(yumak);//Diziden sil
                    _oyunAlaniPanel.Controls.Remove(yumak);//Panelden Sil

                }



            }
            for (var i = _uzumler.Count - 1; i >= 0; i--)
            {

                var uzum = _uzumler[i];
                var topladiMi = uzum.TopladiMi(_kedi);
                if (!topladiMi)
                {
                    if (_uzumler[i].Bottom == _oyunAlaniPanel.Bottom)
                    {
                        _oyunAlaniPanel.Controls.Remove(uzum);
                    }
                    else { continue; }


                }
                if (topladiMi)
                {
                    skorZarar = true; //Yanlış ürünler toplandığında skorun yazdığı label kırmızı renkte olacak.
                    oyuncuSkor -= 20;
                    Degistir = true;
                    _uzumler.Remove(uzum);
                    _oyunAlaniPanel.Controls.Remove(uzum);
                }

            }
            for (var i = _kutular.Count - 1; i >= 0; i--)
            {

                var kutu = _kutular[i];
                var topladiMi = kutu.TopladiMi(_kedi);
                if (!topladiMi)
                {

                    if (_kutular[i].Bottom == _oyunAlaniPanel.Bottom)
                    {
                        _oyunAlaniPanel.Controls.Remove(kutu);
                    }
                    else { continue; }
                }
                if (topladiMi)
                {
                    Random rasgele = new Random();//Süpriz kutuda eğer rastgele üretilen sayı 
                    int rasgeleSayi = rasgele.Next(1, 2);
                    if (rasgeleSayi == 1)//ise fayda
                    {
                        oyuncuSkor += 100;
                    }
                    else//degilse zarar sağlayacak.
                    {
                        skorZarar = true;
                        oyuncuSkor -= 100;
                    }
                    Degistir = true;
                    _kutular.Remove(kutu);
                    _oyunAlaniPanel.Controls.Remove(kutu);
                }


            }
            for (var i = _fareler.Count - 1; i >= 0; i--)
            {

                var fare = _fareler[i];
                var topladiMi = fare.TopladiMi(_kedi);
                if (!topladiMi)
                {
                    if (_fareler[i].Bottom == _oyunAlaniPanel.Bottom)
                    {
                        _oyunAlaniPanel.Controls.Remove(fare);
                    }
                    else { continue; }
                }


                if (topladiMi)
                {
                    if (faresayisi == 0) faresayisi = 0;
                    else
                    {
                        faresayisi--;
                        oyuncuSkor += 20;
                        Degistir = true;

                    }
                    _fareler.Remove(fare);
                    _oyunAlaniPanel.Controls.Remove(fare);

                }

            }
            for (var i = _mamalar.Count - 1; i >= 0; i--)
            {

                var mama = _mamalar[i];
                var topladiMi = mama.TopladiMi(_kedi);
                if (!topladiMi)
                {
                    if (_mamalar[i].Bottom == _oyunAlaniPanel.Bottom)
                    {
                        _oyunAlaniPanel.Controls.Remove(mama);
                    }
                    else { continue; }
                }


                if (topladiMi)
                {
                    if (mamasayisi == 0) mamasayisi = 0;
                    else
                    {
                        mamasayisi--;
                        Degistir = true;
                        oyuncuSkor += 30;
                    }

                    _mamalar.Remove(mama);
                    _oyunAlaniPanel.Controls.Remove(mama);

                }


            }
            for (var i = _cikolatalar.Count - 1; i >= 0; i--)
            {

                var cikolata = _cikolatalar[i];
                var topladiMi = cikolata.TopladiMi(_kedi);
                if (!topladiMi)
                {
                    if (_cikolatalar[i].Bottom == _oyunAlaniPanel.Bottom)
                    {
                        _oyunAlaniPanel.Controls.Remove(cikolata);
                    }
                    else { continue; }

                }
                if (topladiMi)
                {
                    skorZarar = true;
                    oyuncuSkor -= 10;
                    Degistir = true;
                    _cikolatalar.Remove(cikolata);
                    _oyunAlaniPanel.Controls.Remove(cikolata);
                }




            }
            if (GecenSure.TotalSeconds == oyuncuSure)//Eğer GirisFormda girilen süre oyun süresiyle aynı olduğunda oyun biter.
            {
                bittiMi = true;
                sonucMetin = "Süren Bitti";
            }
            if (mamasayisi == 0 && yumaksayisi == 0 && faresayisi == 0)//Toplanan ürünler eksiltilerek sıfır olduğunda Toplamdan düşer

            {
                oyuncuToplam--;
                if (oyuncuToplam == 0 && GecenSure.TotalSeconds <= oyuncuSure) //Eğer toplananlar bittiyse oyun biter
                {
                    bittiMi = true;
                    sonucMetin = "Tebrikler";
                }
                else//Bitmediyse tekrar devam eder.
                {
                    mamasayisi = 3;
                    faresayisi = 2;
                    yumaksayisi = 1;

                }



                // MessageBox.Show("1.Bölümü Bitirdin");
            }


        }
        //Geçen süre ve hız arttırma işlemleri
        private void GecenSureTimer_Tick(object sender, EventArgs e)
        {
            GecenSure += TimeSpan.FromSeconds(1);
            //Gecen süre 15 olduğunda hzını arttır.
            if (GecenSure.TotalSeconds == 15)
            {
                _hareketTimer.Interval = 80;
            }
            if (GecenSure.TotalSeconds == 25)
            {
                _hareketTimer.Interval = 50;
            }

        }

        //Geçen süreye göre nesneleri oluşturacak.
        private void FareOlusturmaTimer_Tick(object sender, EventArgs e)
        {

            FareOlustur();

        }
        private void UzumOlusturmaTimer_Tick(object sender, EventArgs e)
        {

            UzumOlustur();

        }
        private void CikolataOlusturmaTimer_Tick(object sender, EventArgs e)
        {

            CikolataOlustur();

        }
        private void KutuOlusturmaTimer_Tick(object sender, EventArgs e)
        {

            KutuOlustur();


        }
        private void YumakOlusturmaTimer_Tick(object sender, EventArgs e)
        {
            YumakOlustur();
        }
        private void MamaOlusturmaTimer_Tick(object sender, EventArgs e)
        {
            MamaOlustur();
        }
        //Ürünleri oluşturma metotları
        private void FareOlustur()//Panelde yeni fare oluşturuluyor.
        {
           
            var fare = new Fare(_oyunAlaniPanel.Size);
      
            _fareler.Add(fare);
            _oyunAlaniPanel.Controls.Add(fare);
        }
        private void UzumOlustur()//Panelde yeni fare oluşturuluyor.
        {
            var uzum = new Uzum(_oyunAlaniPanel.Size);
            _uzumler.Add(uzum);
            _oyunAlaniPanel.Controls.Add(uzum);
        }
        private void CikolataOlustur()//Panelde yeni fare oluşturuluyor.
        {
            var cikolata = new Cikolata(_oyunAlaniPanel.Size);
            _cikolatalar.Add(cikolata);
            _oyunAlaniPanel.Controls.Add(cikolata);
        }
        private void KutuOlustur()//Panelde yeni fare oluşturuluyor.
        {
            if (GecenSure.TotalSeconds >= 10)//10 sn geçtikten sonra oluşturacak.
            {
                var kutu = new Kutu(_oyunAlaniPanel.Size);
                _kutular.Add(kutu);
                _oyunAlaniPanel.Controls.Add(kutu);
            }
        }
        private void YumakOlustur()//Panelde yeni yumaklar oluşturuluyor.
        {
            var yumak = new Yumak(_oyunAlaniPanel.Size);
            _yumaklar.Add(yumak);
            _oyunAlaniPanel.Controls.Add(yumak);
        }
        private void MamaOlustur()//Panelde yeni yumaklar oluşturuluyor.
        {
            var mama = new Mama(_oyunAlaniPanel.Size);
            _mamalar.Add(mama);
            _oyunAlaniPanel.Controls.Add(mama);
        }
        private void KediOlustur()//Panelde kedi oluşturuyor
        {

            _kedi = new Kedi(_oyunAlaniPanel.Width, _oyunAlaniPanel.Height, _oyunAlaniPanel.Size);
            _oyunAlaniPanel.Controls.Add(_kedi);

        }

        public void SkorEkle()//Veritabanına oyuncuid ye göre skoru günceller.
        {
            baglan.Open();
            komut = new SqlCommand("UPDATE T_OYUN  SET SKOR=@SKOR WHERE OYUNCU_ID='" + oyuncuID + "'", baglan);
            komut.Parameters.AddWithValue("@SKOR", oyuncuSkor);
            komut.ExecuteNonQuery();
            baglan.Close();

        }
        private void BilgileriGetir()//Veritabnından T_Oyun tablosundaki verileri getirir ve bu verileri
                                     //Anaformdaki labellardakullanmak için
                                     //public değişkenlere atar.
        {
            baglan.Open();
            komut = new SqlCommand("Select * From T_OYUN Where OYUNCU_ID=" + oyuncuID, baglan);


            data = komut.ExecuteReader();
            if (data.Read())
            {
                oyuncuIsım = data[1].ToString();
                oyuncuToplam = Convert.ToInt32(data[2]);
                oyuncuSure = Convert.ToInt32(data[3]);

            }

            baglan.Close();


        }

        private void ZamanlayicilariBaslat()//Bütün timerları başlatır.
        {
            _gecensureTimer.Start();
            _hareketTimer.Start();
            _fareOlusturTimer.Start();
            _yumakOlusturTimer.Start();
            _mamaOlusturTimer.Start();
            _uzumOlusturTimer.Start();
            _cikolataOlusturTimer.Start();
            _kutuOlusturTimer.Start();

        }
        private void ZamanlayicilariBitir()//Bütün timerları bitirir.
        {
            _gecensureTimer.Stop();
            _hareketTimer.Stop();
            _fareOlusturTimer.Stop();
            _yumakOlusturTimer.Stop();
            _mamaOlusturTimer.Stop();
            _uzumOlusturTimer.Stop();
            _cikolataOlusturTimer.Stop();
            _kutuOlusturTimer.Stop();

        }


        public void Baslat()//Enter tuşuna basıldığında ürünleri oluştur.
        {


            if (DevamEdiyor) return;
            DevamEdiyor = true;
            ZamanlayicilariBaslat();

            if (!DurdurulduMu)
            {
                KediOlustur();
                FareOlustur();
                YumakOlustur();
                MamaOlustur();
                KutuOlustur();
                UzumOlustur();
                CikolataOlustur();
            }
            BilgileriGetir();





        }
        public void Durdur()//Eğer P tuşuna basıldıysa durdur.
        {
            if (!DevamEdiyor) return;
            DevamEdiyor = false;
            ZamanlayicilariBitir();
            DurdurulduMu = true;


        }
        public void Bitir()//Oyun devam etmiyorsa bitir
        {
            if (!DevamEdiyor) return;
            DevamEdiyor = false;
            if (sonucMetin == "Tebrikler")
            {
                SkorEkle();
            }

            ZamanlayicilariBitir();
            // _oyunAlaniPanel.Controls.Clear();
        }

        public void Hareket(Yon yon)//Kedininin sağ sol hareketleri
        {
            _kedi.HareketEttir(yon);
        }
        #endregion
    }
}
