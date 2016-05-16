﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vyDonemProjesi
{
    public class IsKontroller
    {
        private BaglıListe blIsyeri; //bağlı liste
        private BaglıListe blEgitimDurumu;
        private IkiliArama ikiliArama;

        public IsKontroller()
        {
            blIsyeri = new BaglıListe();
            blEgitimDurumu = new BaglıListe();
            ikiliArama = new IkiliArama();
        }
        public void kisiEkle(Kisi kisi)
        {
            ikiliArama.Ekle(kisi);
        }
        public void kisiGuncelle(Kisi kisi) // param sayısı artacak belki farklı birşeyde bulunabilir düzeltilecek
        {

        }
        public İkiliAramaAgacDugumu kisiAra(string ad)
        {
            İkiliAramaAgacDugumu bstn = ikiliArama.Ara(ad);
            if (bstn == null)
            {
                return null;
            }
            return bstn;
            //Kisi k = (Kisi)bstn.veri;
            //System.Windows.Forms.MessageBox.Show(k.Ad + " " + k.Adres);
        }
        public void blIsyeriEkle(IsYeri iy)
        {
            if (blIsyeri.Head == null)
                blIsyeri.InsertFirst(iy);
            else
                blIsyeri.InsertLast(iy);
        }
        public void blEgitimEkle(EgitimDurumu ed)
        {
            if (blEgitimDurumu.Head == null)
                blEgitimDurumu.InsertFirst(ed);
            else
                blEgitimDurumu.InsertLast(ed);
        }

        public int Goster()
        {
            return ikiliArama.DugumSayisi();
        }
        public string Goster2()
        {
            ikiliArama.PreOrder();
            return ikiliArama.DugumleriYazdir();
        }
    }
}