using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace vyDonemProjesi
{
    /* PROBLEMLER && ÇÖZÜM ÖNERİLERİ
     * hashtable içersinde sirket.isilani isilani içersinde heap heap in düğümlerinde işe başvuran kişiler
     * sağda solda ilan no var düzeltilecek 
     * 
     */
    public class ElemanKontroller
    {
        //bunlar list'e dönüşecek
        //Sirket[] sirket;
        private List<Sirket> sirketler;
        Sirket sirket;
        //Heap[] heap = new Heap[10];
        HashMapChain hash;
        private int ilanNo;
        private int sirketNo;
        // her bir isyeri içerisinde is ilani ve o iş ilani içerisinde işe başvuru yapan elemanlar yanlış
        // heap te sirketin.isilani
        public ElemanKontroller()
        {
            //sirket = new Sirket[10]; // deneme amaçlı max size 10
            sirketler = new List<Sirket>();
            //eleman = new Eleman();
            hash = new HashMapChain();

            ilanNo = 0;
            //sirketNo = 0;
        }
        public void sirketEkle(string adres, string telefon, string faks, string eposta)
        {
            //sirket[sirketNo] = new Sirket();
            //sirket[sirketNo].tamAdres = adres;
            //sirket[sirketNo].Telefon = telefon;
            //sirket[sirketNo].Faks = faks;
            //sirket[sirketNo].EPosta = eposta;

            sirket = new Sirket();
            sirket.tamAdres = adres;
            sirket.Telefon = telefon;
            sirket.Faks = faks;
            sirket.EPosta = eposta;
            sirketler.Add(sirket);

            // buraya değerler form2 den mi gelece ? 

        }
        
        public Sirket sirketBul(string sirketTelefon)
        {
            Sirket retSirket = new Sirket();
            foreach (Sirket sirket in sirketler)
            {
                if (sirket.Telefon == sirketTelefon)
                {
                    retSirket = sirket;
                }
            }
            return retSirket;
        }
        // isyerini hangi sirkete ekleyecek bilmiyoruz o yüzden sirketbul metodundan gelen sirket ile bunu tespit ediyoruz
        public void isYeriEkle(Sirket sirket,string ad, string adres, string gorev, string pozisyon)
        {
            sirket.isyeri = new IsYeri();
            sirket.isyeri.Adi = ad;
            sirket.isyeri.Adres = adres;
            sirket.isyeri.Gorev = gorev;
            sirket.isyeri.Pozisyon = pozisyon;
            //hash.Add(ilanNo++, sirket);
        }
        public void isIlaniEkle(Sirket sirket,string isTanimi, string arananOzellikler)
        {
            //sirket eklendiği zaman sirketno 1 artacağı için -1 alındı
            sirket.isIlani = new IsIlani();
            sirket.isIlani.isTanimi = isTanimi;
            sirket.isIlani.arananOzellikler = arananOzellikler;
            hash.Add(ilanNo, sirket.isIlani);
            ilanNo++;
            //hash.Add((ilanNo), sirket[sirketNo]);
            //ilanNo++;
            //sirketNo++;
        }
        public void isBasvurusuYap(Sirket sirket,Kisi kisi)
        {
            double uygunluk = GetRandomNumber(0.0, 10.0);
            kisi.iseUygunluk = uygunluk;
            if(sirket.isIlani!=null)
                sirket.isIlani.elemanEkle(kisi, ilanNo);
            else
                System.Windows.Forms.MessageBox.Show("İş ilani olmayan bir Şirkete başvuramazsınız");
            //heap[ilanNo-1] = new Heap(10);
            //heap[ilanNo - 1].Insert(kisi);
        }
        public void isListele(Sirket sirket)
        { 
            //  ? ? 
            
        }

        
        public double GetRandomNumber(double minimum, double maximum)
        {
            Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }
    }
}
