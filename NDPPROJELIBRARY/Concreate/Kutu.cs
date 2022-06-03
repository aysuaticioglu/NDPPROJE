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

namespace NDPPROJELIBRARY.Concreate
{

    internal class Kutu : Cisim
    {
        private static readonly Random Random = new Random();
        public Kutu(Size hareketAlanBoyutlari) : base(hareketAlanBoyutlari)//Yumakların rastgele düşmesi
        {
            HareketMesafesi = (int)(Height * 0.1);
            Left = Random.Next(hareketAlanBoyutlari.Width - Width + 1);
        }
        public bool TopladiMi(Kedi kedi)
        {
            var topladiMi = kedi.Top < Bottom && kedi.Right > Left && kedi.Left < Right;
            if (topladiMi) return true;
            return false;
        }

    }
}
