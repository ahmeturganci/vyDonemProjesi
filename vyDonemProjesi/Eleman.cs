using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vyDonemProjesi
{
    public class Eleman
    {
        private List<Kisi> kisiList { get; set; }
        public Eleman()
        {
            kisiList = new List<Kisi>();
        }
        public void elemanEkle(Kisi kisi)
        {
            kisiList.Add(kisi);
        }
    }
}
