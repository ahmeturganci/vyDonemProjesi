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
        Sirket s;
        public Form2()
        {
            InitializeComponent();
            this.s = new Sirket();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s.tamAdres = txtTamAdres.Text;
            s.Telefon = txtPo.Text;
            s.Faks = txtFax.Text;
            s.EPosta = txtIsmail.Text;
            ek.sirketEkle(s.tamAdres, s.Telefon, s.Faks, s.EPosta);


        }

        private void button6_Click(object sender, EventArgs e)//ilan ver 
        {
            //iş bilgileri


            s.isIlani.arananOzellikler = txtArananOzellik.Text;
            s.isIlani.isTanimi = txtIsTanim.Text;
            s.isIlani.isAdi = txtIsAd.Text;
            s.isIlani.isAdres = txtIsAdres.Text;
            s.isIlani.isGorev = txtGorev.Text;
            s.isIlani.isMail = txtIsmail.Text;
            s.isIlani.isPozisyon = txtPo.Text;

            ek.isIlaniEkle(s, s.isIlani.isTanimi, s.isIlani.arananOzellikler);



        }

        private void button5_Click(object sender, EventArgs e)
        {
            //veri çekme olayı yapılacak ? 
            string s = " ";

            foreach (var item in )
            {
                s+=item.

            }
        }
    }
}
