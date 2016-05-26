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

        int ilanNo;
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
            Kisi k = ik.getKisi(kisi);
            k.Ad = txtGad.Text;
            k.egitimDurumu = new EgitimDurumu();
            k.egitimDurumu.ortalama = Convert.ToDouble(txtGort.Text);
            textTemizle(this);
            ik.kisiGuncelle(k);
            ik.kisiEkle(k);
            listKisi.Update();
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
                for (int j = 0; j < hd.Length; j++)
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
                Kisi kisi = (Kisi)bstn.veri;
                listListeleme.Items.Add(kisi.Ad + " " + kisi.Adres + " " + kisi.DogumTarihi + "" + kisi.DogumYeri + "" + kisi.egitimDurumu.Bolum);
            }
        }

        private void btnOrtalama_Click(object sender, EventArgs e)
        {
            listListeleme.Items.Clear();
            listListeleme.Items.Add(ik.ortListele());
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
            listListeleme.Items.Add(ik.preOrderListele());
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            listListeleme.Items.Clear();
            listListeleme.Items.Add(ik.inOrderListeleme());
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            listListeleme.Items.Clear();
            listListeleme.Items.Add(ik.postOrderListeleme());
        }
    }
}
