﻿using System;
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

        int ilanNo;
        string eskiKisiAdi = "";
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
        }
        private void btnKisiEkle_Click(object sender, EventArgs e)
        {

            //ağaçla bağlı listeteye elemanlar eklendi.
            Kisi kisi = new Kisi();
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
            kisi.YabanciDil = txtYabanciDil.Text;

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
            ik.blEgitimEkle(kisi.egitimDurumu);
            ik.blIsyeriEkle(kisi.isYeri);
            ik.kisiEkle(kisi);
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
                eskiKisiAdi = kisi.Ad;
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
            Kisi kisi = new Kisi();
            İkiliAramaAgacDugumu bstn = ik.kisiAra(eskiKisiAdi);
            ik.kisiSil(bstn);
            kisi.Ad = txtGad.Text;
            kisi.Adres = txtGadres.Text;
            kisi.Email = txtGmail.Text;
            kisi.Telefon = txtGtel.Text;
            kisi.Uyruk = txtGuyruk.Text;
            kisi.DogumYeri = txtGdogumYeri.Text;
            kisi.DogumTarihi = txtGdogumTarih.Text;
            kisi.MedeniDurum = txtGmedeniDurum.Text;
            kisi.IlgiAlanlari = txtGilgiAlani.Text;
            kisi.Referans = txtGreferans.Text;
            kisi.YabanciDil = txtGyabanciDil.Text;

            kisi.egitimDurumu = new EgitimDurumu();
            kisi.egitimDurumu.BaslangicYil = txtGbaslamaYili.Text;
            kisi.egitimDurumu.BittisYil = txtGbitisYili.Text;
            kisi.egitimDurumu.Bolum = txtGbolum.Text;
            kisi.egitimDurumu.MezunOlunanOkul = txtGokul.Text;
            kisi.egitimDurumu.ortalama = Convert.ToDouble(txtGort.Text);

            kisi.isYeri = new IsYeri();
            kisi.isYeri.Adi = txtGisyeriAdi.Text;
            kisi.isYeri.Adres = txtGisAdres.Text;
            kisi.isYeri.Gorev = txtGgorev.Text;
            kisi.isYeri.Pozisyon = txtGpo.Text;
            ik.blEgitimEkle(kisi.egitimDurumu);
            ik.blIsyeriEkle(kisi.isYeri);
            ik.kisiEkle(kisi);
            //ek.kisiBasvuruGuncelle(eskiKisiAdi, k);
            textTemizle(this);
            listKisi.Items.Remove(eskiKisiAdi);
            listKisi.Items.Add(kisi.Ad);
            basvuruListele();
            MessageBox.Show("Güncelleme başarılı");
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
            Sirket sirket = new Sirket();
            Adi = txtIsAd.Text;
            Adres = txtIsAdres.Text;
            Gorev = txtGorev.Text;
            Email = txtEmail.Text;
            Pozisyon = txtPo.Text;
            sirket.isyeri = new IsYeri();
            ek.isYeriEkle(sirket, Adi, Adres, Gorev, Pozisyon);

            isTanimi = txtIsTanim.Text;
            arananOzellikler = txtArananOzellik.Text;
            sirket.isIlani = new IsIlani();
            ek.isIlaniEkle(sirket, isTanimi, arananOzellikler);
            textTemizle(this);//textboxları temizleme
            listIsIlanlari.Items.Add(ek.isIlaniGetir(ek.ilanNo - 1));
        }

        private void btnIseBasvur_Click(object sender, EventArgs e)
        {
            ilanNo = listIsIlanlari.SelectedIndex; //ilk değer 0 = 100
            ilanNo += 100;
            Sirket s = ek.isIlaniGetirCast(ilanNo);
            if (kisi == null)
                MessageBox.Show("Kişi seçmediniz.");
            else
            {
                ek.isBasvurusuYap(s, kisi);
                basvuruListele();
                MessageBox.Show("başvuru yapıldı");
            }
        }
        public void basvuruListele()
        {
            lbilanBasvurulariListele.Items.Clear();
            for (int i = 100; i < ek.ilanNo; i++)
            {
                HeapDugumu[] hd = ek.basvurulariListele(i);
                for (int j = 0; j < ek.currentSize; j++)
                {
                    if (hd[j] != null)
                        lbilanBasvurulariListele.Items.Add(hd[j].Deger.Ad + " " + hd[j].Deger.iseUygunluk);
                }
            }
        }
        public void kisiTakas() // başvuru işlemleri için kişiler listbox dan kişi seçme
        {
            string kisiAd = listKisi.GetItemText(listKisi.SelectedItem);
            İkiliAramaAgacDugumu bstn = ik.kisiAra(kisiAd);
            Kisi kisi = new Kisi();
            kisi = (Kisi)bstn.veri;
            if (kisi != null)
                this.kisi = kisi;
            else
                MessageBox.Show("Kişi seçilemedi.");
        }

        private void listKisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            kisi = null;
            if (listKisi.SelectedIndex != -1)
                kisiTakas();
        }

        private void btnListeleme_Click(object sender, EventArgs e)
        {
            listListeleme.Items.Clear();
            İkiliAramaAgacDugumu bstn = ik.kisiAra(txtList.Text);
            if (bstn == null)
                MessageBox.Show("Aranan kişi bulunamadı...");
            else
            {
                Kisi kisi = bstn.veri;
                string s = kisi.Ad + " " + kisi.Adres + " " + kisi.DogumTarihi + " " + kisi.DogumYeri + " " + kisi.egitimDurumu.Bolum + " " + kisi.YabanciDil;
                listListeleme.Items.Add(s);
            }
        }

        private void btnOrtalama_Click(object sender, EventArgs e)
        {
            listListeleme.Items.Clear();
            string s = ik.ortalamaListele();
            string[] str = s.Split('/');
            foreach (string i in str)
            {
                listListeleme.Items.Add(i);
            }
        }

        private void btnIseAl_Click(object sender, EventArgs e)
        {
            string s = lbilanBasvurulariListele.GetItemText(lbilanBasvurulariListele.SelectedItem);
            //string parse edilip heap sınıfı içersinde remove edilecek ek olarak ilgili şirketin eleman kadrosuna dahil edilecek...
            //şimdilik 
            string[] ad = s.Split(' ');
            string kisiAd = "";
            foreach (string i in ad)
            {
                kisiAd = i;
                break;
            }
            ek.iseAl(ilanNo, kisiAd);
            MessageBox.Show(s + "\nİşe alındınız.");

            lbilanBasvurulariListele.Items.Remove(lbilanBasvurulariListele.SelectedItem);
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            listListeleme.Items.Clear();
            string s = ik.preOrderListele();
            string[] str = s.Split('/');
            foreach (string i in str)
            {
                listListeleme.Items.Add(i);
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            listListeleme.Items.Clear();
            string s = ik.inOrderListeleme();
            string[] str = s.Split('/');
            foreach (string i in str)
            {
                listListeleme.Items.Add(i);
            }
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            listListeleme.Items.Clear();
            string s = ik.postOrderListeleme();
            string[] str = s.Split('/');
            foreach (string i in str)
            {
                listListeleme.Items.Add(i);
            }
        }

        private void btnKisiSil_Click(object sender, EventArgs e)
        {
            string kisiAd = txtKisiAdiSil.Text;
            İkiliAramaAgacDugumu bstn = ik.kisiAra(kisiAd);
            if (bstn == null)
                MessageBox.Show("Aranan kişi bulunamadı...");
            else
            {
                if (ik.kisiSil(bstn))
                {
                    listKisi.Items.Remove(kisiAd);
                    for (int i = 100; i < ek.ilanNo; i++)
                    {
                        ek.iseAl(i, kisiAd);
                    }

                    MessageBox.Show("Kişi siindi.");
                }
                else
                    MessageBox.Show("Kişi silinemedi...");

            }
            basvuruListele();
        }

        private void btnDugumSayisi_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ik.dugumSayisi().ToString());
        }

        private void btnDerinlik_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ik.derinlikSayisi().ToString());
        }

        private void btnIngBilenler_Click(object sender, EventArgs e)
        {
            listListeleme.Items.Clear();
            listListeleme.Items.Clear();
            string s = ik.ingilizceBilenler();
            string[] str = s.Split('/');
            foreach (string i in str)
            {
                listListeleme.Items.Add(i);
            }
        }
    }
}
