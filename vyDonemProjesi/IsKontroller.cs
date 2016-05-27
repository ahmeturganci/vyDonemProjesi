using System;
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
        Kisi kisi;

        public IsKontroller()
        {
            blIsyeri = new BaglıListe();
            blEgitimDurumu = new BaglıListe();
            ikiliArama = new IkiliArama();
            kisi = new Kisi();
        }
        public string preOrderListele()
        {
            ikiliArama.PreOrder();
            return ikiliArama.DugumleriYazdir();
        }
        public string inOrderListeleme()
        {
            ikiliArama.InOrder();
            return ikiliArama.DugumleriYazdir();
        }
        public string postOrderListeleme()
        {
            ikiliArama.PostOrder();
            return ikiliArama.DugumleriYazdir();
        }
        public string ingilizceBilenler()
        {
            ikiliArama.IngilizceBilenler();
            return (ikiliArama.DugumleriYazdir());
        }
        public string ortalamaListele()
        {
            ikiliArama.OrtalamaListele();
            return (ikiliArama.DugumleriYazdir());
        }
        public void kisiEkle(Kisi kisi)
        {
            ikiliArama.Ekle(kisi);
        }

        public İkiliAramaAgacDugumu kisiAra(string ad)
        {
            İkiliAramaAgacDugumu bstn = ikiliArama.Ara(ad);
            if (bstn == null)
            {
                return null;
            }
            return bstn;
        }
        public void blIsyeriEkle(IsYeri iy)
        {
            iy = new IsYeri();
            if (blIsyeri.Head == null)
                blIsyeri.InsertFirst(iy);
            else
                blIsyeri.InsertLast(iy);
        }
        public void blEgitimEkle(EgitimDurumu ed)
        {
            ed = new EgitimDurumu();
            if (blEgitimDurumu.Head == null)
                blEgitimDurumu.InsertFirst(ed);
            else
                blEgitimDurumu.InsertLast(ed);
        }

        public Kisi getKisi(Kisi k)
        {
            return k;
        }
        public void kisiGuncelle(Kisi kisi)
        {
            //if adı değiştirdiyse 
            //ağaçtan kisiyi sil yeni kisi ekle
            //else 
            this.kisi.Ad = kisi.Ad;
            //this.kisi.Adres = kisi.Adres;
            //this.kisi.DogumTarihi = kisi.DogumTarihi;
            //this.kisi.DogumYeri = kisi.DogumYeri;
            //this.kisi.Email = kisi.Email;
            //this.kisi.IlgiAlanlari = kisi.IlgiAlanlari;
            //this.kisi.Referans = kisi.Referans;
            //this.kisi.YabanciDil = kisi.YabanciDil;
            //this.kisi.Uyruk = kisi.Uyruk;
            //this.kisi.MedeniDurum = kisi.MedeniDurum;
            this.kisi.egitimDurumu = new EgitimDurumu();
            //this.kisi.egitimDurumu.BaslangicYil = kisi.egitimDurumu.BaslangicYil;
            //this.kisi.egitimDurumu.BittisYil = kisi.egitimDurumu.BittisYil;
            //this.kisi.egitimDurumu.Bolum = kisi.egitimDurumu.Bolum;
            //this.kisi.egitimDurumu.MezunOlunanOkul = kisi.egitimDurumu.MezunOlunanOkul;
            this.kisi.egitimDurumu.ortalama = kisi.egitimDurumu.ortalama;

            //this.kisi.isYeri = new IsYeri();
            //this.kisi.isYeri.Adi = kisi.isYeri.Adi;
            //this.kisi.isYeri.Adres = kisi.isYeri.Adres;
            //this.kisi.isYeri.Email = kisi.isYeri.Email;
            //this.kisi.isYeri.Gorev = kisi.isYeri.Gorev;
            //this.kisi.isYeri.Pozisyon = kisi.isYeri.Pozisyon;
        }
        public void kisiListele()
        {
            ikiliArama.PostOrder();
        }
        public bool kisiSil(İkiliAramaAgacDugumu kisi)
        {
            return (ikiliArama.Sil(kisi));
        }
        public int dugumSayisi()
        {
            return (ikiliArama.DugumSayisi());
        }
        public int derinlikSayisi()
        {
            return (ikiliArama.Derinlik());
        }
    }
}
