using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vyDonemProjesi
{
    public class İkiliAramaAgacDugumu
    {
        public object veri;
        public İkiliAramaAgacDugumu sol;
        public İkiliAramaAgacDugumu sag;
        public İkiliAramaAgacDugumu()
        {
        }

        public İkiliAramaAgacDugumu(object veri)
        {
            this.veri = veri;
            sol = null;
            sag = null;
        }
    }
}
