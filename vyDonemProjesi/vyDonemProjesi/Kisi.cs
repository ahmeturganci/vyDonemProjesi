using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vyDonemProjesi
{
   public class Kisi
    {
        public string Ad { get; set; }
        public string Adres { get; set; }
        public string Email  { get; set; }
        public string Telefon { get; set; }
        public string Uyruk { get; set; }
        public string DogumYeri { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string MedeniDurum{ get; set; }
        public string YabanciDil { get; set; }
        public string IlgiAlanlari { get; set; }
        public string[] Referans { get; set; }
        EgitimDurumu egitimDurum { get; set; }
        public Kisi()
        {
            this.egitimDurum = new EgitimDurumu();
        }



 
    }
}
