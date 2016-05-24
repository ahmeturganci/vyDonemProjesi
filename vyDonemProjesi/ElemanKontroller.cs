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
     * isyerini hangi sirkete ekleyecek bilmiyoruz o yüzden sirketbul metodundan gelen sirket ile bunu tespit ediyoruz
     * iş ilanı sınıfında değişiklik yapıldı heap[] -> heap (kritik düzenleme)
     * iş başvurusu yaparken ilan no eklemek değilde iş ilanı verirken ilan no eklendi (önemli düzenleme)
     * HeapDugum sınıfına düzenleme yapılacak cast için (yapıldı)
     * heap de ceviri düzenle
     */
    public class ElemanKontroller
    {
        private List<Sirket> sirketler;
        Sirket sirket;
        HashMapChain hash;
        public int ilanNo { get; private set; }
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
            hash.Add(ilanNo, sirket);
            //isIlaniGetir(ilanNo);
            ilanNo++;
        }
        public string isIlaniGetir(int ilanNo)
        {
            string s;
            Sirket ilan=hash.isIlaniGetir(ilanNo);
            if(ilan!=null)
                s =ilan.isyeri.Adi+" "+ilan.isIlani.arananOzellikler + " " +ilan.isIlani.isTanimi;
            else
                s="ilan yok";
            return s;
            //System.Windows.Forms.MessageBox.Show(s);
        }
        public void isBasvurusuYap(Sirket sirket, Kisi kisi)
        {
            double uygunluk = GetRandomNumber(0.0, 10.0);
            kisi.iseUygunluk = uygunluk;
            if (sirket.isIlani != null)
                sirket.isIlani.elemanEkle(kisi);
            else
                System.Windows.Forms.MessageBox.Show("İş ilani olmayan bir Şirkete başvuramazsınız");
        }

        public double GetRandomNumber(double minimum, double maximum)
        {
            Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }
    }
}
