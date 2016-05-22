using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vyDonemProjesi
{
    public class LinkedHashEntry
    {
        private int anahtar;

        public int Anahtar
        {
            get { return anahtar; }
            set { anahtar = value; }
        }

        private object deger;

        public object Deger
        {
            get { return deger; }
            set { deger = value; }
        }

        private LinkedHashEntry next;

        public LinkedHashEntry Next
        {
            get { return next; }
            set { next = value; }
        }


        public LinkedHashEntry(int anahtar, object deger)
        {
            this.anahtar = anahtar;
            this.deger = deger;
            this.next = null;
        }

    }
}
