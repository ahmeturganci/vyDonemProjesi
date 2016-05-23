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
    /*
     * iş ilanlarının listelemesi ile ilgili konuşulaca ? 
     * ? anlamadığım yer : şimdi sisteme 1 kişi kayıt oluyor ee o zaman bizim ona göre şirket ve işleri ve başvuran kişileri aynı anda oluşturup değer atamalarını yapacağız ? 
     * 
     */
    public partial class Form1 : Form
    {
        Kisi kisi = new Kisi();
        IsKontroller k = new IsKontroller();
        ElemanKontroller ek = new ElemanKontroller();

        Kisi ahmet = new Kisi();
        Kisi mehmet = new Kisi();
        Kisi kamil = new Kisi();
        Kisi nuri = new Kisi();
        public Form1()
        {
            
            InitializeComponent();
           //PATLIYOR   
            //txtAd.DataBindings.Add("Text", kisi.Ad, "Ad");
            //txtAdres.DataBindings.Add("Text", kisi.Adres, "Adres");
            //txtMail.DataBindings.Add("Text", kisi.Email, "Adres");
            //txtTelefon.DataBindings.Add("Text", kisi.Telefon, "Adres");
            //txtUyruk.DataBindings.Add("Text", kisi.Uyruk, "Uyruk");
            //txtDogunYeri.DataBindings.Add("Text", kisi.DogumYeri, "DogumYeri");
            //txtDogunYeri.DataBindings.Add("Text", kisi.DogumTarihi, "DogumTarihi");
            //txtMedeniDurum.DataBindings.Add("Text", kisi.MedeniDurum, "MedeniDurum");
            //txtIlgiAlani.DataBindings.Add("Text", kisi.IlgiAlanlari, "IlgiAlanlari");
            //txtReferans.DataBindings.Add("Text", kisi.Referans, "Referans");

            //txtOkul.DataBindings.Add("Text", kisi.egitimDurumu.MezunOlunanOkul, "MezunOlunanOkul");
            //txtBolum.DataBindings.Add("Text", kisi.egitimDurumu.Bolum, "Bolum");
            //txtBaslangic.DataBindings.Add("Text", kisi.egitimDurumu.BaslangicYil, "BaslangicYil");
            //txtBitis.DataBindings.Add("Text", kisi.egitimDurumu.BittisYil, "BittisYil");
            //txtOrtalama.DataBindings.Add("Text", kisi.egitimDurumu.ortalama, "ortalama");

            //txtEskiIs.DataBindings.Add("Text", kisi.isYeri.Adi, "Adi");
            //txtEskiAdres.DataBindings.Add("Text", kisi.isYeri.Adres, "Adres");
            //txtPo.DataBindings.Add("Text", kisi.isYeri.Pozisyon, "Pozisyon");
            //txtGorev.DataBindings.Add("Text", kisi.isYeri.Gorev, "Gorev");
           

        }

       
        
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

           /*

              MessageBox.Show(k.Goster().ToString()); // bir sıkıntı yok gibi ama daha fazla test yapılması gerekli
              MessageBox.Show(k.Goster2());*/
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            ////k.kisiAra("ahmet"); // deneme patlak verecek ekrana yazdırmayacaktır.
            //İkiliAramaAgacDugumu bstn = k.kisiAra("p");
            //if (bstn != null)
            //{
            //    Kisi kisi = (Kisi)bstn.veri;
            //    MessageBox.Show(kisi.Ad + " " + kisi.Adres); // artırılacak...
            //}
            //else
            //    MessageBox.Show("Aranan kayıt bulunamadı");
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
            //ek.isYeriEkle("", "", "", "");
            //ek.isIlaniEkle("", "");
            //Heap h = new Heap(4);
            //Kisi k = new Kisi();
            //k.Ad = "D";
            //Kisi k2 = new Kisi();
            //k2.Ad = "a";
            //Kisi k3 = new Kisi();
            //k3.Ad = "c";
            
            //h.Insert(k);
            //h.Insert(k2);
            //h.Insert(k3);
            //h.DisplayHeap();
            //h.RemoveMax();
            //ek.sirketEkle("meg","turgutlu","faks","eposta");
            //ek.isYeriEkle("ad", "adres", "gorev", "pozisyon");
            //ek.isIlaniEkle("istanimi", "ozellikler");
            //ek.isBasvurusuYap(ahmet);
            //ek.isBasvurusuYap(mehmet);


        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //button text=X
            //testler
            ek.sirketEkle("turgutlu", "12345", "fakss", "mail@mail.com");
            ek.sirketEkle("turgutlu1", "123422135", "ssfakss", "gmail@gmail.com");
            Sirket sirket= ek.sirketBul("12345");
            ek.isYeriEkle(sirket, "meg", "manisa", "gor", "poz");
            sirket = ek.sirketBul("123422135");
            ek.isYeriEkle(sirket, "au", "muğla", "gor2", "poz2");
            ek.isIlaniEkle(sirket, "yazılım mühendisi", "backend developer");
            ek.isBasvurusuYap(sirket, ahmet);
            ek.isBasvurusuYap(sirket, mehmet);
            sirket = ek.sirketBul("12345");
            //eğer bu şirkete iş ilani eklemeden çalıştırsaydık null ref den dolayı patlardı düzeltildi
            ek.isIlaniEkle(sirket, "yazılım mühendisi", "frontend developer");
            ek.isBasvurusuYap(sirket, nuri);
            ek.isBasvurusuYap(sirket, kamil);


        }

        private void button1_Click(object sender, EventArgs e)//kaydol
        {

            //ağaçla bağlı listeteye elemanlar erklendi. 
            kisi.Ad = txtAd.Text;
            kisi.Adres = txtAdres.Text;
            kisi.Email = txtMail.Text;
            kisi.Telefon= txtTelefon.Text;
            kisi.Uyruk = txtUyruk.Text;
            kisi.DogumYeri = txtDogunYeri.Text;
            kisi.DogumTarihi = txtDogumTarihi.Text;
            kisi.MedeniDurum = txtMedeniDurum.Text;
            kisi.IlgiAlanlari = txtIlgiAlani.Text;
            kisi.Referans = txtReferans.Text;

            kisi.egitimDurumu = new EgitimDurumu();
            kisi.egitimDurumu.BaslangicYil =txtBaslangic.Text; 
            kisi.egitimDurumu.BittisYil =txtBitis.Text;
            kisi.egitimDurumu.Bolum =txtBolum.Text;
            kisi.egitimDurumu.MezunOlunanOkul =txtOkul.Text;
            kisi.egitimDurumu.ortalama = Convert.ToDouble(txtOrtalama.Text);

            kisi.isYeri = new IsYeri();
            kisi.isYeri.Adi = txtEskiIs.Text;
            kisi.isYeri.Adres = txtEskiAdres.Text;
            kisi.isYeri.Gorev = txtGorev.Text;
            kisi.isYeri.Pozisyon = txtPo.Text;

            k.kisiEkle(kisi);
            k.blEgitimEkle(kisi.egitimDurumu);
            k.blIsyeriEkle(kisi.isYeri);

            

        }

        private void txtOkul_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtAd.Text = kisi.Ad;
        }

        private void button2_Click(object sender, EventArgs e)
        {
                
        }
        //public class Data : INotifyPropertyChanged
        //{
        //    private string deger;

        //    public string Deger
        //    {
        //        get { return deger; }
        //        set { deger = value;
        //        if (PropertyChanged != null)
        //            PropertyChanged(this, new PropertyChangedEventArgs("Deger"));
        //        }
        //    }


        //    public event PropertyChangedEventHandler PropertyChanged;
        //}

    }
}
