﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace vyDonemProjesi
{
    public class ElemanKontroller
    {
        private List<Sirket> sirketler;
        Sirket sirket;
        HashMapChain hash;
        public int ilanNo { get; private set; }
        public int currentSize { get; private set; }
        public ElemanKontroller()
        {
            sirketler = new List<Sirket>();
            hash = new HashMapChain();
            ilanNo = 100;
        }
        public void sirketEkle(string adres, string telefon, string faks, string eposta)
        {
            sirket = new Sirket();
            sirket.tamAdres = adres;
            sirket.Telefon = telefon;
            sirket.Faks = faks;
            sirket.EPosta = eposta;
            sirketler.Add(sirket);
        }
        public Sirket getSirket()
        {
            return this.sirket;
        }
        public void isYeriEkle(Sirket sirket, string ad, string adres, string gorev, string pozisyon)
        {
            sirket.isyeri = new IsYeri();
            sirket.isyeri.Adi = ad;
            sirket.isyeri.Adres = adres;
            sirket.isyeri.Gorev = gorev;
            sirket.isyeri.Pozisyon = pozisyon;
        }
        public void isIlaniEkle(Sirket sirket, string isTanimi, string arananOzellikler)
        {
            sirket.isIlani = new IsIlani();
            sirket.isIlani.isTanimi = isTanimi;
            sirket.isIlani.arananOzellikler = arananOzellikler;
            if (this.sirket != null)
            {
                sirket.tamAdres = this.sirket.tamAdres;
                sirket.Telefon = this.sirket.Telefon;
                sirket.Faks = this.sirket.Faks;
                sirket.Telefon = this.sirket.Telefon;
            }
            hash.Add(ilanNo, sirket);
            ilanNo++;
        }
        public string isIlaniGetir(int ilanNo)
        {
            string s;
            Sirket ilan = hash.isIlaniGetir(ilanNo);
            if (ilan != null)
                s = ilan.isyeri.Adi + " " + ilan.isIlani.arananOzellikler + " " + ilan.isIlani.isTanimi;
            else
                s = "ilan yok";
            return s;
        }
        public Sirket isIlaniGetirCast(int ilanNo)
        {
            Sirket ilan = hash.isIlaniGetir(ilanNo);
            return ilan;
        }
        public void isBasvurusuYap(Sirket sirket, Kisi kisi)
        {            
            if (sirket.isIlani != null)
                sirket.isIlani.elemanEkle(kisi);
            else
                System.Windows.Forms.MessageBox.Show("İş ilani olmayan bir Şirkete başvuramazsınız");
        }
        public void sirketGuncelle(Sirket sirket)
        {
            this.sirket.tamAdres = sirket.tamAdres;
            this.sirket.Telefon = sirket.Telefon;
            this.sirket.Faks = sirket.Faks;
            this.sirket.EPosta = sirket.EPosta;
        }
        public HeapDugumu[] basvurulariListele(int i)
        {
            Sirket ilan = getSirket();
            ilan = hash.isIlaniGetir(i);
            HeapDugumu[] hd = new HeapDugumu[ilan.isIlani.heap.heapArray.Length];
            if (ilan != null)
            {
                hd = ilan.isIlani.heap.heapArray;
                currentSize = ilan.isIlani.heap.currentSize;
            }


            return hd;
        }
        //public void kisiBasvuruGuncelle(string eskiKisiAdi, Kisi yeniKisi)
        //{
        //    Sirket ilan = getSirket();
        //    for (int i = 100; i < this.ilanNo; i++)
        //    {
        //        ilan = hash.isIlaniGetir(i);
        //        if (ilan != null)
        //        {
        //            ilan.isIlani.heap.kisiBasvuruKontrol(eskiKisiAdi, yeniKisi);
        //        }
        //    }
        //}
        public void iseAl(int ilanNo,string kisiAd)
        {
            Sirket ilan = getSirket();
            ilan = hash.isIlaniGetir(ilanNo);

            if (ilan != null)
                ilan.isIlani.heap.kisiSil(kisiAd);
        }
    }
}