using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vyDonemProjesi
{
    public class Kontroller
    {
        private BaglıListe blIsyeri;
        private BaglıListe blEgitimDurumu;
        private IkiliArama ikiliArama;
        private int id;
        public Kontroller()
        {
            id = 1;
            blIsyeri = new BaglıListe();
            blEgitimDurumu = new BaglıListe();
            ikiliArama = new IkiliArama();
        }
        public void kisiEkle(Kisi kisi)
        {
            ikiliArama.Ekle(kisi);
            id++;
        }
        public void blIsyeriEkle(IsYeri iy)
        {
            if (blIsyeri.Head == null)
                blIsyeri.InsertFirst(iy);
            else
                blIsyeri.InsertLast(iy);
        }
        public void blEgitimEkle(EgitimDurumu ed)
        {
            if (blEgitimDurumu.Head == null)
                blEgitimDurumu.InsertFirst(ed);
            else
                blEgitimDurumu.InsertLast(ed);
        }

        public int Goster()
        {
            return ikiliArama.DugumSayisi();
        }
    }
}
