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
        public string isAdi { get; set; }
        public string isAdres { get; set; }
        public string isMail { get; set; }
        public string isPozisyon { get; set; }
        public string isGorev { get; set; }
        //private List<Kisi> kisiList { get; set; }
        Heap[] heap;
        
        public IsIlani()
        {
            //kisiList = new List<Kisi>();
            heap = new Heap[10];
        }
        public void elemanEkle(Kisi kisi,int ilanNo)
        {
            //kisiList.Add(kisi);
            heap[ilanNo] = new Heap(10);
            heap[ilanNo].Insert(kisi);

        }
        //private Eleman eleman { get; set; }
        //public IsIlani()
        //{
        //    eleman = new Eleman();
        //}
    }
}
