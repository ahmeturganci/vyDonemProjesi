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
        Sirket s = new Sirket();
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
            s.tamAdres = txtTamAdres.Text;
            s.Telefon = txtTelefon.Text;
            s.Faks = txtFax.Text;
            s.EPosta = txtIsmail.Text;
            ek.sirketEkle(s.tamAdres, s.Telefon, s.Faks, s.EPosta);
        }

        private void button6_Click(object sender, EventArgs e)//ilan ver 
        {
            s.isyeri = new IsYeri();
            s.isyeri.Adi = txtIsAd.Text;
            s.isyeri.Adres = txtIsAdres.Text;
            s.isyeri.Gorev = txtGorev.Text;
            s.isyeri.Email = txtIsmail.Text;
            s.isyeri.Pozisyon = txtPo.Text;
            s.isIlani = new IsIlani();
            s.isIlani.isTanimi = txtIsTanim.Text;
            s.isIlani.arananOzellikler = txtArananOzellik.Text;
            ek.isYeriEkle(s, s.isyeri.Adi, s.isyeri.Adres, s.isyeri.Gorev, s.isyeri.Pozisyon);
            ek.isIlaniEkle(s, s.isIlani.isTanimi, s.isIlani.arananOzellikler);
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

        private void button7_Click(object sender, EventArgs e)
        {
            textBox4.Text = s.tamAdres;
            textBox3.Text = s.Telefon;
            textBox2.Text = s.Faks;
            textBox1.Text = s.EPosta;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSirketGuncelle_Click(object sender, EventArgs e)
        {
          
        }
    }
}
