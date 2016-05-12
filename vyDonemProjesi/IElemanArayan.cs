using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vyDonemProjesi
{
    public interface IElemanArayan
    {
        Eleman Kayit();
        void Guncelle();
        void IlanVe();
        void AdayListele();
        void EnUygunuIseAl();//heapten öncelikli kuyrukla çekilecek
            

    }
}
