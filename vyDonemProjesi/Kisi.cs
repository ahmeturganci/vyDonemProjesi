using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vyDonemProjesi
{
   public class Kisi
    {
        public int id { get; set; }
        public string Ad { get; set; }
        public string Adres { get; set; }
        public string Email  { get; set; }
        public string Telefon { get; set; }
        public string Uyruk { get; set; }
        public string DogumYeri { get; set; }
        public string DogumTarihi { get; set; }
        public string MedeniDurum{ get; set; }
        public string YabanciDil { get; set; }
        public string IlgiAlanlari { get; set; }
        public string Referans { get; set; }
        public EgitimDurumu egitimDurumu { get; set; }
        public IsYeri isYeri { get; set; }
        public Kisi()
        {
            //egitimDurumu = new EgitimDurumu();
            //isYeri = new IsYeri();
        }



 
    }
}
