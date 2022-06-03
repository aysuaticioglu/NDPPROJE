﻿/****************************************************************************
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
using NDPPROJELIBRARY.Enum;
using NDPPROJELIBRARY.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDPPROJELIBRARY.Abstract
{

    internal abstract class Cisim : PictureBox, IHareketEden
    {

        public Size HareketAlaniBoyutlari { get; }

        public int HareketMesafesi { get; protected set; }

        public new int Right
        {
            get => base.Right;
            set => Left = value - Width;
        }
        public new int Bottom
        {
            get => base.Bottom;
            set => Top = value - Height;
        }
        protected Cisim(Size hareketAlaniBoyutlari)
        {
            Image = Image.FromFile($@"..\..\..\NDPPROJE\Assets\{GetType().Name}.png");//class isimlerine sahip resimler
            HareketAlaniBoyutlari = hareketAlaniBoyutlari;
            SizeMode = PictureBoxSizeMode.AutoSize;



        }
        public int Center
        {
            get => Left + Width / 2;
            set => Left = value - Width / 2;
        }
        public int Middle
        {
            get => Top + Height / 2;
            set => Top = value - Height / 2;
        }

        //Hareketleri yöne göre çağır
        public bool HareketEttir(Yon yon)
        {
            switch (yon)
            {
                case Yon.Yukari:
                    return YukariHareketEttir();
                case Yon.Saga:

                    return SagaHareketEttir();
                case Yon.Asagi:
                    return AsagiHareketEttir();
                case Yon.Sola:
                    return SolaHareketEttir();
                default:
                    throw new ArgumentOutOfRangeException(nameof(yon), yon, null);


            }



        }
        //Hareket yönleri
        private bool SolaHareketEttir()
        {
            if (Left == 0)
            {
                return true;
            }
            var yeniLeft = Left - HareketMesafesi;
            var tasacakMi = yeniLeft < 0;
            Left = tasacakMi ? 0 : yeniLeft;
            return Left == 0;


        }
        private bool AsagiHareketEttir()
        {
            if (Bottom == HareketAlaniBoyutlari.Height)
            {
                return true;
            }
            var yeniBottom = Bottom + HareketMesafesi;
            var tasacakMi = yeniBottom > HareketAlaniBoyutlari.Height;

            Bottom = tasacakMi ? HareketAlaniBoyutlari.Height : yeniBottom;

            return Bottom == HareketAlaniBoyutlari.Height;
        }
        private bool SagaHareketEttir()
        {
            if (Right == HareketAlaniBoyutlari.Width)
            {
                return true;
            }
            var yeniRight = Right + HareketMesafesi;
            var tasacakMi = yeniRight > HareketAlaniBoyutlari.Width;

            Right = tasacakMi ? HareketAlaniBoyutlari.Width : yeniRight;

            return Right == HareketAlaniBoyutlari.Width;
        }
        private bool YukariHareketEttir()
        {
            if (Top == 0)
            {
                return true;
            }
            var yeniTop = Top - HareketMesafesi;
            var tasacakMi = yeniTop < 0;
            Top = tasacakMi ? 0 : yeniTop;
            return Top == 0;
        }
    }
}