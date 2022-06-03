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


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.DataVisualization.Charting;
using System.Windows.Forms;
using NDPPROJELIBRARY.Concreate;

namespace NDPPROJE
{
    public partial class GirisForm : Form
    {

        SqlConnection baglan = new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ToString());
        SqlCommand komut;
        public int oyuncuID;
        public string ad;

        public GirisForm()
        {
            InitializeComponent();


        }

        private void btnOyna_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == "" && txtMiktar.Text == "" && txtSure.Text == "")//Textboxların boş mu kontrolü
            {

                MessageBox.Show("Boş Alanları Doldurun");

                return;

            }
            else
            {
                BilgileriEkle();//Eğer doldurulması gereken alanlar boş değilse metodu çağrıcak.
                AnaForm anaform = new AnaForm();
                anaform.oyuncuID = oyuncuID;
                anaform.oyuncuIsim = txtAd.Text;
                anaform.oyuncuSure = Convert.ToInt32(txtSure.Text);
                anaform.oyuncuToplam = Convert.ToInt32(txtMiktar.Text);
                anaform.Show();
                this.Hide();
            }

        }
        //Veritabanına girilen bilgileri ekler.
        public void BilgileriEkle()
        {
           
           
                baglan.Open();
                komut = new SqlCommand("INSERT INTO T_OYUN VALUES (@OYUNCU_AD,@MIKTAR,@SURE,@SKOR) select scope_identity()", baglan);
                komut.Parameters.AddWithValue("@OYUNCU_ID", oyuncuID);
                komut.Parameters.AddWithValue("@OYUNCU_AD", txtAd.Text);
                komut.Parameters.AddWithValue("@MIKTAR", Convert.ToInt32(txtMiktar.Text));
                komut.Parameters.AddWithValue("@SURE", Convert.ToInt32(txtSure.Text));
                komut.Parameters.AddWithValue("@SKOR", 0);
                oyuncuID = Convert.ToInt32(komut.ExecuteScalar());//Son eklenen oyuncunun idsini alır.
                baglan.Close();
           

        }
        private void GirisForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCikis_Click(object sender, EventArgs e)//Çıkış butonu
        {
            this.Close();
            Application.Exit();
        }

        private void btnSkor_Click(object sender, EventArgs e)//Skor butonu
        {
            SkorForm skorfrm = new SkorForm();
            skorfrm.Show();
        }

        private void btnBilgi_Click(object sender, EventArgs e)//Bilgi Butonu
        {
            BilgiForm bilgifrm = new BilgiForm();
            bilgifrm.Show();
        }
    }
}
