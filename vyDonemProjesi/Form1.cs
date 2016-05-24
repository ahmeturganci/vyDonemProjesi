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

        Kisi kisi;
        IsKontroller ik = new IsKontroller();
        ElemanKontroller ek = new ElemanKontroller();

        Kisi ahmet = new Kisi();
        Kisi mehmet = new Kisi();
        Kisi kamil = new Kisi();
        Kisi nuri = new Kisi();
        public void textTemizle(Control clt)
        {
            foreach (Control item in clt.Controls)
            {
                if (item is TextBox)
                    ((TextBox)item).Clear();
                if (item.Controls.Count > 0)
                    textTemizle(item);
            }
        }
        public Form1()
        {
            InitializeComponent();
            listIsIlanlari.Items.Clear();
            //form yüklendiğinde şirket işilanı eklediyse o iş ilanlarını getir
        }
        private void btnKisiEkle_Click(object sender, EventArgs e)
        {

            //ağaçla bağlı listeteye elemanlar eklendi.
            kisi = new Kisi();
            kisi.Ad = txtAd.Text;
            kisi.Adres = txtAdres.Text;
            kisi.Email = txtMail.Text;
            kisi.Telefon = txtTelefon.Text;
            kisi.Uyruk = txtUyruk.Text;
            kisi.DogumYeri = txtDogunYeri.Text;
            kisi.DogumTarihi = txtDogumTarihi.Text;
            kisi.MedeniDurum = txtMedeniDurum.Text;
            kisi.IlgiAlanlari = txtIlgiAlani.Text;
            kisi.Referans = txtReferans.Text;

            kisi.egitimDurumu = new EgitimDurumu();
            kisi.egitimDurumu.BaslangicYil = txtBaslangic.Text;
            kisi.egitimDurumu.BittisYil = txtBitis.Text;
            kisi.egitimDurumu.Bolum = txtBolum.Text;
            kisi.egitimDurumu.MezunOlunanOkul = txtOkul.Text;
            kisi.egitimDurumu.ortalama = Convert.ToDouble(txtOrtalama.Text);

            kisi.isYeri = new IsYeri();
            kisi.isYeri.Adi = txtEskiIs.Text;
            kisi.isYeri.Adres = txtEskiAdres.Text;
            kisi.isYeri.Gorev = txtGorev.Text;
            kisi.isYeri.Pozisyon = txtPo.Text;

            ik.kisiEkle(kisi);
            ik.blEgitimEkle(kisi.egitimDurumu);
            ik.blIsyeriEkle(kisi.isYeri);
            MessageBox.Show("kayıt işlemi başarılı");
            textTemizle(this);//textboxları temizleme
            listKisi.Items.Add(kisi.Ad);
        }
        private void btnVericek_Click(object sender, EventArgs e)
        {
            İkiliAramaAgacDugumu bstn = ik.kisiAra(txtAdKim.Text);
            if (bstn == null)
                MessageBox.Show("Aranan kişi bulunamadı...");
            else
            {
                Kisi kisi = (Kisi)bstn.veri;
                txtGad.Text = kisi.Ad;
                txtGadres.Text = kisi.Adres;
                txtGmail.Text = kisi.Email;
                txtGtel.Text = kisi.Telefon;
                txtGdogumYeri.Text = kisi.DogumYeri;
                txtGdogumTarih.Text = kisi.DogumTarihi;
                txtGmedeniDurum.Text = kisi.MedeniDurum;
                txtGyabanciDil.Text = kisi.YabanciDil;
                txtGreferans.Text = kisi.Referans;
                txtGilgiAlani.Text = kisi.IlgiAlanlari;

                txtGokul.Text = kisi.egitimDurumu.MezunOlunanOkul;

                txtGbaslamaYili.Text = kisi.egitimDurumu.BaslangicYil;
                txtGbitisYili.Text = kisi.egitimDurumu.BittisYil;
                txtGort.Text = kisi.egitimDurumu.ortalama.ToString();
                txtGbolum.Text = kisi.egitimDurumu.Bolum; ;

                txtGisyeriAdi.Text = kisi.isYeri.Adi;
                txtGisAdres.Text = kisi.isYeri.Adres;
                txtGpo.Text = kisi.isYeri.Pozisyon;
                txtGgorev.Text = kisi.isYeri.Gorev;
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnKisiGuncelle_Click(object sender, EventArgs e)
        {

        }
        private void btnSirketEkle_Click(object sender, EventArgs e)
        {
            string tamAdres, Telefon, Faks, EPosta;
            tamAdres = txtTamAdres.Text;
            Telefon = txtSirketTel.Text;
            Faks = txtFax.Text;
            EPosta = txtEmail.Text;
            ek.sirketEkle(tamAdres, Telefon, Faks, EPosta);
        }

        private void btnBilgiGetir_Click(object sender, EventArgs e)
        {
            Sirket s = ek.getSirket();
            txtTamAdresGuncelle.Text = s.tamAdres;
            txtTelefonGuncelle.Text = s.Telefon;
            txtFaksGuncelle.Text = s.Faks;
            txtEmailGuncelle.Text = s.EPosta;

        }

        private void btnSirketGuncelle_Click(object sender, EventArgs e)
        {
            //form textbox dolu boş kontrol eklenebilir..
            Sirket s = ek.getSirket();
            s.tamAdres = txtTamAdresGuncelle.Text;
            s.Telefon = txtTelefonGuncelle.Text;
            s.Faks = txtFaksGuncelle.Text;
            s.EPosta = txtEmailGuncelle.Text;
            ek.sirketGuncelle(s);
        }

        private void btnIlanVer_Click(object sender, EventArgs e)
        {
            string Adi, Adres, Gorev, Email, Pozisyon, isTanimi, arananOzellikler;
            Sirket s = ek.getSirket();//
            Adi = txtIsAd.Text;
            Adres = txtIsAdres.Text;
            Gorev = txtGorev.Text;
            Email = txtEmail.Text;
            Pozisyon = txtPo.Text;

            ek.isYeriEkle(s, Adi, Adres, Gorev, Pozisyon);

            isTanimi = txtIsTanim.Text;
            arananOzellikler = txtArananOzellik.Text;
            ek.isIlaniEkle(s, isTanimi, arananOzellikler);
            textTemizle(this);//textboxları temizleme
            listIsIlanlari.Items.Add(ek.isIlaniGetir(ek.ilanNo - 1));
        }

        private void btnIseBasvur_Click(object sender, EventArgs e)
        {
            int ilanNo = listIsIlanlari.SelectedIndex; //ilk değer 0 = 100
            if (ilanNo == 0)
                ilanNo++;
            ilanNo *= 100;
            Sirket s = ek.isIlaniGetirCast(ilanNo);
            if(kisi==null)
                MessageBox.Show("Kişi seçmediniz.");
            else
            ek.isBasvurusuYap(s, kisi);
            lbilanBasvurulariListele.Items.Add(kisi.Ad);
            basvuruListele();
        }
        public void basvuruListele()
        {
            lbilanBasvurulariListele.Items.Clear();
            for (int i = 100; i < ek.ilanNo; i++)
            {
                HeapDugumu[] hd = ek.basvurulariListele(i);
                for (int j = 0; j < hd.Length; j++)
                {
                    if(hd[j]!=null)
                        lbilanBasvurulariListele.Items.Add(ek.ilanNo+" "+hd[j].Deger.Ad);
                }
            }
        }
        public void kisiTakas() // başvuru işlemleri için kişiler listbox dan kişi seçme
        {
            string kisiAd = listKisi.GetItemText(listKisi.SelectedItem);
            İkiliAramaAgacDugumu bstn = ik.kisiAra(kisiAd);
            Kisi kisi = (Kisi)bstn.veri;
            this.kisi = kisi;
        }

        private void listKisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            kisiTakas();
        }  
    }
}
