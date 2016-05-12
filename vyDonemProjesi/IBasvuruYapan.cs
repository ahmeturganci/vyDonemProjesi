using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vyDonemProjesi
{
   public  interface IBasvuruYapan
    {
       Kisi Kaydol(); // sisiteme kisi bilgilerini girecek
       Kisi BilgiGüncelleme();
       void SistemdenCikis();
       object BasvuruYap();




    }
}
