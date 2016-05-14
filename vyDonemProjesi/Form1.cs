using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace vyDonemProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Kontroller k = new Kontroller();
        Kisi ahmet = new Kisi();
        private void btnTest_Click(object sender, EventArgs e)
        {
            
    


            
            ahmet.isYeri = new IsYeri();
            ahmet.egitimDurumu = new EgitimDurumu();
            ahmet.Ad = "ahmetgelmedi";
            ahmet.Adres = "SedocanÖzcanKYKturgutlu";
            ahmet.DogumTarihi = "05.11.1992";
            ahmet.DogumYeri = "manisa";
            ahmet.egitimDurumu.BaslangicYil = "2014";
            ahmet.egitimDurumu.BittisYil = "2018"; // İNŞALLAH
            ahmet.egitimDurumu.Bolum = "yzm";
            ahmet.egitimDurumu.MezunOlunanOkul = "CBÜ";
            ahmet.egitimDurumu.ortalama = 4f;
            ahmet.Email = "sananelan@sananehır.com";
            ahmet.IlgiAlanlari = "ahmet urganci";
            ahmet.MedeniDurum = "Bekar";
            ahmet.Referans = "abcdfegh";

            ahmet.isYeri.Adi = "IŞIK OYUN,IŞIK SİSTEM";
            ahmet.isYeri.Adres = "Bursa/Emek";
            ahmet.isYeri.Gorev = "görev";
            ahmet.isYeri.Pozisyon = "pozisyon";

            k.kisiEkle(ahmet);
            k.blIsyeriEkle(ahmet.isYeri);
            k.blEgitimEkle(ahmet.egitimDurumu);


            Kisi mehmet = new Kisi();
            mehmet.isYeri = new IsYeri();
            mehmet.egitimDurumu = new EgitimDurumu();
            mehmet.Ad = "mehmetgelmedi";
            mehmet.Adres = "SedocanÖzcanKYKturgutlu";
            mehmet.DogumTarihi = "05.11.1992";
            mehmet.DogumYeri = "manisa";
            mehmet.egitimDurumu.BaslangicYil = "2014";
            mehmet.egitimDurumu.BittisYil = "2018"; // İNŞALLAH
            mehmet.egitimDurumu.Bolum = "yzm";
            mehmet.egitimDurumu.MezunOlunanOkul = "CBÜ";
            mehmet.egitimDurumu.ortalama = 4f;
            mehmet.Email = "sananelan@sananehır.com";
            mehmet.IlgiAlanlari = "ahmet urganci";
            mehmet.MedeniDurum = "Bekar";
            mehmet.Referans = "abcdfegh";

            mehmet.isYeri.Adi = "IŞIK OYUN,IŞIK SİSTEM";
            mehmet.isYeri.Adres = "Bursa/Emek";
            mehmet.isYeri.Gorev = "görev";
            mehmet.isYeri.Pozisyon = "pozisyon";

            k.kisiEkle(mehmet);
            k.blIsyeriEkle(mehmet.isYeri);
            k.blEgitimEkle(mehmet.egitimDurumu);

            MessageBox.Show(k.Goster().ToString()); // bir sıkıntı yok gibi ama daha fazla test yapılması gerekli
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            //k.kisiAra("mehmetgelmedi");
            //k.kisiAra("ahmetgelmedi");
            //k.kisiAra("ahmet"); // deneme patlak verecek ekrana yazdırmayacaktır.
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //string ad = "mehmet"; // degerler artacak düzeltilecek
            //string adres = "manisa";
            ////MessageBox.Show(ahmet.Ad + " " + ahmet.Adres + " " + ahmet.DogumYeri);
            ////k.kisiGuncelle(ahmet, ad, adres);
            ////MessageBox.Show(ahmet.Ad + " " + ahmet.Adres + " " + ahmet.DogumYeri);

            //string adAra = "mehmetgelmedi";
            ////X.bu isimdeki kişinin bilgileri değişeceğinden 
            ////X.ağaçtan silip yeni kayıt eklesek ?? ya da ne Hocaya sorulabilir ??
            //İkiliAramaAgacDugumu bstn= k.kisiAra(adAra);
            //Kisi kisi = (Kisi)bstn.veri;
            ////null değer giriş kontrolleri yapılacak
            //kisi.Ad = ad; // null değilse
            //kisi.Adres = adres; // null değilse
            ////yakında eklenecek özellik X. yorumdan yola çıkarak k.sil(adAra) k.kisiEkle(kisi.Ad)



        }

        private void btnSilme_Click(object sender, EventArgs e)
        {

        }
    }
}
