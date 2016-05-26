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
            {
                //Kisi k = new Kisi();
                //k = kisi;
                //k.iseUygunluk = uygunluk;
                //heap.Insert(k);
                double uygunluk = GetRandomNumber(0.0, 10.0);
                kisi.iseUygunluk = uygunluk;
                heap.Insert(kisi);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Aynı işe tekrar başvuramazsınız...");
            }
        }
        public double GetRandomNumber(double minimum, double maximum)
        {
            Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }
    }
}
