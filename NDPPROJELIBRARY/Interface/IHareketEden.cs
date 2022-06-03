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
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDPPROJELIBRARY.Interface
{
    //Cisim sınıfının rehberi
    internal interface IHareketEden
    {

        Size HareketAlaniBoyutlari { get; }
        int HareketMesafesi { get; }
    

        /// <summary>
        /// Cismi istenilen yönde hareket ettirir.
        /// </summary>
        /// <param name="yon">Hangi yöne hareket edileceği</param>
        /// <returns>Cisim duvara çarparsa true döndürür</returns>
        bool HareketEttir(Yon yon);
    }
}
