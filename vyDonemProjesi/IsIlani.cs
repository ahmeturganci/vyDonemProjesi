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
        Heap heap;
        public IsIlani()
        {
            heap = new Heap(10);
        }
        public void elemanEkle(Kisi kisi)
        {
            heap.Insert(kisi);

        }
    }
}
