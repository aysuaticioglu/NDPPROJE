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
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDPPROJE
{
    public partial class SkorForm : Form
    {
        public SkorForm()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ToString());
       
        private void SkorForm_Load(object sender, EventArgs e)//Form yüklendiğinde veritabanında datagride skorları ekler.
        {
            // TODO: This line of code loads data into the 'oYUNDataSet.T_OYUN' table. You can move, or remove it, as needed.
            this.t_OYUNTableAdapter.Fill(this.oYUNDataSet.T_OYUN);
            // TODO: This line of code loads data into the 'oYUNDataSet.T_OYUN' table. You can move, or remove it, as needed.
            this.t_OYUNTableAdapter.Fill(this.oYUNDataSet.T_OYUN);
            DataTable tablo = new DataTable();
            baglan.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT TOP 5 OYUNCU_AD,SKOR FROM T_OYUN ORDER BY SKOR DESC", baglan);
            adtr.Fill(tablo);
            dtgSkor.DataSource = tablo;
            baglan.Close();
        }
    }
}
