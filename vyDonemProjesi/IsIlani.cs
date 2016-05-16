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
        private List<Kisi> kisiList { get; set; }
        public IsIlani()
        {
            kisiList = new List<Kisi>();
        }
        public void elemanEkle(Kisi kisi)
        {
            kisiList.Add(kisi);
        }
        //private Eleman eleman { get; set; }
        //public IsIlani()
        //{
        //    eleman = new Eleman();
        //}
    }
}
