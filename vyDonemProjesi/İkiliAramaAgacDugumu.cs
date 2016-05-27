using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vyDonemProjesi
{
    public class İkiliAramaAgacDugumu
    {
        public Kisi veri;
        public İkiliAramaAgacDugumu sol;
        public İkiliAramaAgacDugumu sag;
        public İkiliAramaAgacDugumu()
        {
        }

        public İkiliAramaAgacDugumu(Kisi veri)
        {
            this.veri = veri;
            sol = null;
            sag = null;
        }
    }
}
