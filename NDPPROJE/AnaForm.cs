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


using NDPPROJELIBRARY.Concreate;
using System;
using System.Windows.Forms;
using NDPPROJELIBRARY.Enum;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;

namespace NDPPROJE
{
    public partial class AnaForm : Form
    {
        private readonly Oyun _oyun;
        public int oyuncuID;
        public int oyuncuSure;
        public int oyuncuToplam;

        public string oyuncuIsim;

        public int sure;



        public AnaForm()
        {

            InitializeComponent();
            _oyun = new Oyun(oyunAlaniPanel);
            _oyun.GecensureDegisti += Oyun_GecenSureDegisti;

    


        }

        private void AnaForm_KeyDown(object sender, KeyEventArgs e)//Klavyeden tuşa tuşa basınca gerçekleşecekler
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    _oyun.Baslat();
                    break;
                case Keys.Right:
                    _oyun.Hareket(Yon.Saga);
                    break;
                case Keys.Left:
                    _oyun.Hareket(Yon.Sola);
                    break;
                case Keys.P:
                    _oyun.Durdur();
                    break;
            }


        }


        private void Oyun_GecenSureDegisti(object sender, EventArgs e)
        {
            SonucPanel.Visible = false;
            sureLabel.Text = _oyun.GecenSure.ToString(@"m\:ss");//Oyun süresini yazar

            if (_oyun.Degistir)//Toplananları 
            {
                Toplanan();
            }
            _oyun.Degistir = false;
            if (_oyun.bittiMi)//Oyun bittiyse sonuç metnini yazar
            {
                SonucPanel.Visible = true;
                SonucLabel.Text = _oyun.sonucMetin;
                if (_oyun.sonucMetin=="Tebrikler")//Kazandıysa skoru yazar
                {
                    SkorLabel.Text= "Skorunuz:"+_oyun.oyuncuSkor.ToString(); 

                }
                _oyun.Bitir();

            }


        }
        private void AnaForm_Load(object sender, EventArgs e)
        {
            _oyun.dondur = false;

            if (oyuncuID != 0)//Veritabnından gelen oyuncu id
            {
                _oyun.oyuncuID = oyuncuID;
                lblisim.Text = oyuncuIsim;
                lbltoplam.Text = oyuncuToplam.ToString();
                lblkalan.Text = oyuncuToplam.ToString();

            }

        }
        private void Toplanan()
        {


            lblmama.Text = _oyun.mamasayisi.ToString();
            lblyumak.Text = _oyun.yumaksayisi.ToString();
            lblfare.Text = _oyun.faresayisi.ToString();
            lblkalan.Text = _oyun.oyuncuToplam.ToString();
            if (_oyun.skorZarar)//Eğer yanlış ürün toplarsa label kırmızı olacak
            {
                lblskor.ForeColor = System.Drawing.Color.Red;
                _oyun.skorZarar = false;
            }
            else//Değilse yeşil
            {
                lblskor.ForeColor = System.Drawing.Color.Green;
            }
            lblskor.Text = _oyun.oyuncuSkor.ToString();//ve skoru yazacak
        }

        private void btnanamenu_Click(object sender, EventArgs e)//Oyun bittiğinde Giriş formuna dönüş butonu
        {
            GirisForm girisfrm = new GirisForm();
            girisfrm.Show();
            this.Hide();
        }

       
    }
}
