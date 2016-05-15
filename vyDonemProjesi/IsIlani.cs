using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vyDonemProjesi
{
    public class IsIlani
    {
        private Eleman eleman { get; set; }
        public string isTanimi { get; set; }
        public string arananOzellikler { get; set; }

        public IsIlani()
        {
            eleman = new Eleman();
        }
    }
}
