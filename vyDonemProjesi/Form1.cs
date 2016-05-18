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

        IsKontroller k = new IsKontroller();
        ElemanKontroller ek = new ElemanKontroller();
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
            ahmet.egitimDurumu.ortalama = 85;
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
            mehmet.egitimDurumu.ortalama = 90;
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


            Kisi nuri = new Kisi();
            nuri.isYeri = new IsYeri();
            nuri.egitimDurumu = new EgitimDurumu();
            nuri.Ad = "nurigelmedi";
            nuri.Adres = "SedocanÖzcanKYKturgutlu";
            nuri.DogumTarihi = "05.11.1992";
            nuri.DogumYeri = "manisa";
            nuri.egitimDurumu.BaslangicYil = "2014";
            nuri.egitimDurumu.BittisYil = "2018"; // İNŞALLAH
            nuri.egitimDurumu.Bolum = "yzm";
            nuri.egitimDurumu.MezunOlunanOkul = "CBÜ";
            nuri.egitimDurumu.ortalama = 85;
            nuri.Email = "sananelan@sananehır.com";
            nuri.IlgiAlanlari = "nuri urganci";
            nuri.MedeniDurum = "Bekar";
            nuri.Referans = "abcdfegh";

            nuri.isYeri.Adi = "IŞIK OYUN,IŞIK SİSTEM";
            nuri.isYeri.Adres = "Bursa/Emek";
            nuri.isYeri.Gorev = "görev";
            nuri.isYeri.Pozisyon = "pozisyon";

            k.kisiEkle(nuri);
            k.blIsyeriEkle(nuri.isYeri);
            k.blEgitimEkle(nuri.egitimDurumu);


            Kisi kamil = new Kisi();
            kamil.isYeri = new IsYeri();
            kamil.egitimDurumu = new EgitimDurumu();
            kamil.Ad = "kamilgelmedi";
            kamil.Adres = "SedocanÖzcanKYKturgutlu";
            kamil.DogumTarihi = "05.11.1992";
            kamil.DogumYeri = "manisa";
            kamil.egitimDurumu.BaslangicYil = "2014";
            kamil.egitimDurumu.BittisYil = "2018"; // İNŞALLAH
            kamil.egitimDurumu.Bolum = "yzm";
            kamil.egitimDurumu.MezunOlunanOkul = "CBÜ";
            kamil.egitimDurumu.ortalama = 85;
            kamil.Email = "sananelan@sananehır.com";
            kamil.IlgiAlanlari = "kamil urganci";
            kamil.MedeniDurum = "Bekar";
            kamil.Referans = "abcdfegh";

            kamil.isYeri.Adi = "IŞIK OYUN,IŞIK SİSTEM";
            kamil.isYeri.Adres = "Bursa/Emek";
            kamil.isYeri.Gorev = "görev";
            kamil.isYeri.Pozisyon = "pozisyon";

            k.kisiEkle(kamil);
            k.blIsyeriEkle(kamil.isYeri);
            k.blEgitimEkle(kamil.egitimDurumu);



            MessageBox.Show(k.Goster().ToString()); // bir sıkıntı yok gibi ama daha fazla test yapılması gerekli
            MessageBox.Show(k.Goster2());
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            //k.kisiAra("ahmet"); // deneme patlak verecek ekrana yazdırmayacaktır.
            İkiliAramaAgacDugumu bstn = k.kisiAra("p");
            if (bstn != null)
            {
                Kisi kisi = (Kisi)bstn.veri;
                MessageBox.Show(kisi.Ad + " " + kisi.Adres); // artırılacak...
            }
            else
                MessageBox.Show("Aranan kayıt bulunamadı");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            // ad güncelleniyorsa kisiyi silip yeni kisi ekle çünkü bst üzerinde ad dan dolayı yeri değişecek


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

        private void btnBasvuru_Click(object sender, EventArgs e)
        {
            ek.isYeriEkle("", "", "", "");
            ek.isIlaniEkle("", "");
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
