using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vyDonemProjesi
{
    class BagliListeADT
    {
        public Node Head;
        public int Size = 0;
        public abstract void InsertFirst(int value);
        public abstract void InsertLast(int value);
        public abstract void InsertPos(int position, int value);
        public abstract void DeleteFirst();
        public abstract void DeleteLast();
        public abstract void DeletePos(int position);
        public abstract Node GetElement(int position);

        public abstract string DisplayElements();   
    }
}
