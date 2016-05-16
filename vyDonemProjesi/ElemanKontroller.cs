using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace vyDonemProjesi
{
    public class ElemanKontroller
    {
        Sirket sirket;
        Heap heap;
        Hashtable hash;
        Eleman eleman;
        private int ilanNo;
        // her bir isyeri içerisinde is ilani ve o iş ilani içerisinde işe başvuru yapan elemanlar yanlış
        // heap te sirketin.isilani
        public ElemanKontroller()
        {
            sirket = new Sirket();
            heap = new Heap(10); // deneme amaçlı max size 10
            hash = new Hashtable();
            eleman = new Eleman();
            ilanNo = 100;
        }
        public void isYeriEkle(string ad, string adres, string gorev, string pozisyon)
        {
            sirket.isyeri = new IsYeri();
            sirket.isyeri.Adi = "ABCYAZILIM";
            sirket.isyeri.Adres = "Turgutlu/Manisa";
            sirket.isyeri.Gorev = "Test";
            sirket.isyeri.Pozisyon = "Yazılım Mühendisi";
            hash.Add(ilanNo++, sirket);
        }
        public void isIlaniEkle(string isTanimi, string arananOzellikler)
        {
            sirket.isIlani = new IsIlani();
            sirket.isIlani.isTanimi = "verilen bilgiler ile projeyi test etme";
            sirket.isIlani.arananOzellikler = "Yazılım Mühendisi";
            // heap.Insert() // heap e ayar çekilecek
        }
        public void isBasvurusuYap(int ilanNo)
        {
            //hashtable ilannoyu bul o ilanın 
        }
    }
}
