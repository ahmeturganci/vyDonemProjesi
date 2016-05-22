using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace vyDonemProjesi
{
    public class ElemanKontroller
    {
        //bunlar arraylist dönüşecek
        Sirket[] sirket;
        //Heap[] heap = new Heap[10];
        HashMapChain hash;
        Eleman eleman;
        private int ilanNo;
        private int sirketNo;
        // her bir isyeri içerisinde is ilani ve o iş ilani içerisinde işe başvuru yapan elemanlar yanlış
        // heap te sirketin.isilani
        public ElemanKontroller()
        {
            sirket = new Sirket[10]; // deneme amaçlı max size 10
            eleman = new Eleman();
            hash = new HashMapChain();
            
            ilanNo = 0;
            sirketNo = 0;
        }
        public void sirketEkle(string adres, string telefon, string faks, string eposta)
        {
            sirket[sirketNo] = new Sirket();
            sirket[sirketNo].tamAdres = adres;
            sirket[sirketNo].Telefon = telefon;
            sirket[sirketNo].Faks = faks;
            sirket[sirketNo].EPosta = eposta;
        }
        public void isYeriEkle(string ad, string adres, string gorev, string pozisyon)
        {
            sirket[sirketNo].isyeri = new IsYeri();
            sirket[sirketNo].isyeri.Adi = ad;
            sirket[sirketNo].isyeri.Adres = adres;
            sirket[sirketNo].isyeri.Gorev = gorev;
            sirket[sirketNo].isyeri.Pozisyon = pozisyon;
            //hash.Add(ilanNo++, sirket);
        }
        public void isIlaniEkle(string isTanimi, string arananOzellikler)
        {
            //sirket eklendiği zaman sirketno 1 artacağı için -1 alındı
            sirket[sirketNo].isIlani = new IsIlani();
            sirket[sirketNo].isIlani.isTanimi = isTanimi;
            sirket[sirketNo].isIlani.arananOzellikler = arananOzellikler;
            //hash.Add((ilanNo), sirket[sirketNo]);
            ilanNo++;
            sirketNo++;
        }
        public void isBasvurusuYap(Kisi kisi)
        {
            double uygunluk = GetRandomNumber(0.0, 10.0);
           // kisi.iseUygunluk = uygunluk;
            sirket[sirketNo].isIlani.elemanEkle(kisi, ilanNo);
            hash.Add(ilanNo, sirket[sirketNo].isIlani);
            //heap[ilanNo-1] = new Heap(10);
            //heap[ilanNo - 1].Insert(kisi);
        }
        public double GetRandomNumber(double minimum, double maximum)
        {
            Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }
    }
}
