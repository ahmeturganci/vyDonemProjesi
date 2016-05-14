using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vyDonemProjesi
{
    public class HeapSort
    {
        private int[] dizi;
        public HeapSort(int[] dizi)
        {
            this.dizi = dizi;
        }

        public int[] Sort()
        {
            Heap h = new Heap(dizi.Length);
            int[] sorted = new int[dizi.Length];
            
            foreach (var item in dizi)
                h.Insert(item);
            int i = 0;
            
            while (!h.IsEmpty())
                sorted[i++] = h.RemoveMax().Deger;
            return sorted;
        }

    }
}
