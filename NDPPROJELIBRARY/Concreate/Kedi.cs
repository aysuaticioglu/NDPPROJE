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

using NDPPROJELIBRARY.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDPPROJELIBRARY.Concreate
{
    internal class Kedi : Cisim
    {
        public Kedi(int panelGenisligi,int panelYuksekligi ,Size hareketAlaniBoyutlari) : base(hareketAlaniBoyutlari)
            //Kedininin paneldeki yüksekliği ,genişliği,
        {

            
            HareketMesafesi = Width;
            Bottom =(panelYuksekligi-6) -Top;
            Center = panelGenisligi / 2;
        }
     
    }
}
