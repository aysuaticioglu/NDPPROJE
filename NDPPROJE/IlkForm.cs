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
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDPPROJE
{
    public partial class IlkForm : Form
    {



        public IlkForm()
        {
            InitializeComponent();
        }
        int saniye = 0;
        private void IlkForm_Load(object sender, EventArgs e)
        {

            timer1.Start();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            saniye++;
          
            if (saniye == 70)///0 saniye sonra GirisForma gider
            {
                GirisForm girisfrm = new GirisForm();
                timer1.Stop();
                this.Hide();
                girisfrm.Show();
            }

        }
    }
}
