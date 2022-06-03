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
namespace NDPPROJELIBRARY.Interface
{
    //Oyun sınıfının rehberi
    internal interface IOyun
    {
        event EventHandler GecensureDegisti;
        
        bool DevamEdiyor { get; }
        TimeSpan GecenSure { get; }

        void Baslat();
       
        void Hareket(Yon yon);


    }
}
