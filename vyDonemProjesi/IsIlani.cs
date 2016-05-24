using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vyDonemProjesi
{
    public class IsIlani
    {
        public string isTanimi { get; set; }
        public string arananOzellikler { get; set; }
        public Heap heap { get; set; }
        public IsIlani()
        {
            heap = new Heap(10);
        }
        public void elemanEkle(Kisi kisi)
        {
            if (!heap.basvuruKontrol(kisi))
                heap.Insert(kisi);
            else
                System.Windows.Forms.MessageBox.Show("Aynı işe tekrar başvuramazsınız...");
        }
    }
}
