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

        private void btnTest_Click(object sender, EventArgs e)
        {
            Kontroller k = new Kontroller();
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
    }
}
