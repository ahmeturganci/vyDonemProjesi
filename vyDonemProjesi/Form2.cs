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


    public partial class Form2 : Form
    {
        IsKontroller k = new IsKontroller();
        ElemanKontroller ek = new ElemanKontroller();
        
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
        public Form2()
        {
            InitializeComponent();


        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string tamAdres, Telefon, Faks, EPosta;
            tamAdres = txtTamAdres.Text;
            Telefon = txtTelefon.Text;
            Faks = txtFax.Text;
            EPosta = txtEmail.Text;
            ek.sirketEkle(tamAdres,Telefon,Faks,EPosta);
        }

        private void button6_Click(object sender, EventArgs e)//ilan ver 
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
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //veri çekme olayı yapılacak ? 



        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e) // bilgileri getir
        {
            Sirket s = ek.getSirket();
            txtTamAdresGuncelle.Text = s.tamAdres;
            txtTelefonGuncelle.Text = s.Telefon;
            txtFaksGuncelle.Text = s.Faks;
            txtEmailGuncelle.Text = s.EPosta;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSirketGuncelle_Click(object sender, EventArgs e)
        {
            // form textbox dolu boş kontrol eklenebilir..
            Sirket s = ek.getSirket();
            s.tamAdres = txtTamAdresGuncelle.Text;
            s.Telefon = txtTelefonGuncelle.Text;
            s.Faks = txtFaksGuncelle.Text;
            s.EPosta = txtEmailGuncelle.Text;
            ek.sirketGuncelle(s);
        }
    }
}
