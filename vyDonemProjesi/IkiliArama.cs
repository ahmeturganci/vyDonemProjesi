using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vyDonemProjesi
{
    public class IkiliArama
    {
        private İkiliAramaAgacDugumu kok;
        private string dugumler;
        private List<Kisi> doksanUstu = new List<Kisi>();
        public IkiliArama()
        {
        }
        public IkiliArama(İkiliAramaAgacDugumu kok)
        {
            this.kok = kok;
        }
        public string ortListele()
        {
            string s = "";
            foreach (var item in doksanUstu)
            {
                s += item.Ad + "" + item.egitimDurumu.ortalama.ToString() + " " + item.egitimDurumu.MezunOlunanOkul + Environment.NewLine;
            }
            return s;
        }
        public int DugumSayisi()
        {
            return DugumSayisi(kok);
        }
        public int DugumSayisi(İkiliAramaAgacDugumu dugum)
        {
            int count = 0;
            if (dugum != null)
            {
                count = 1;
                count += DugumSayisi(dugum.sol) + DugumSayisi(dugum.sag);
            }
            return count;
        }
        public int YaprakSayisi()
        {
            return YaprakSayisi(kok);
        }
        public int YaprakSayisi(İkiliAramaAgacDugumu dugum)
        {
            int count = 0;
            if (dugum != null)
            {
                if ((dugum.sol == null) && (dugum.sag == null))
                    count = 1;
                else
                    count = count + YaprakSayisi(dugum.sol) + YaprakSayisi(dugum.sag);
            }
            return count;
        }


        public string DugumleriYazdir()
        {
            return dugumler;
        }
        public void PreOrder()
        {
            dugumler = "";
            PreOrderInt(kok);
        }
        private void PreOrderInt(İkiliAramaAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            Ziyaret(dugum);
            PreOrderInt(dugum.sol);
            PreOrderInt(dugum.sag);
        }
        public void InOrder()
        {
            dugumler = "";
            InOrderInt(kok);
        }
        private void InOrderInt(İkiliAramaAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            InOrderInt(dugum.sol);
            Ziyaret(dugum);
            InOrderInt(dugum.sag);
        }
        private void Ziyaret(İkiliAramaAgacDugumu dugum)
        {
            Kisi k = (Kisi)dugum.veri;
            dugumler += k.Ad + " " + k.Adres + "" + k.DogumTarihi + " " + k.DogumYeri + " " + k.egitimDurumu.MezunOlunanOkul + " " + k.egitimDurumu.ortalama.ToString() + " " + k.isYeri.Adi + " " + k.isYeri.Gorev + "\n";
        }
        public void PostOrder()
        {
            dugumler = "";
            PostOrderInt(kok);
        }
        private void PostOrderInt(İkiliAramaAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            PostOrderInt(dugum.sol);
            PostOrderInt(dugum.sag);
            Ziyaret(dugum);
        }
        public void Ekle(object deger)
        {
            İkiliAramaAgacDugumu tempParent = new İkiliAramaAgacDugumu();
            İkiliAramaAgacDugumu tempSearch = kok;
            Kisi k = new Kisi();
            Kisi k2 = new Kisi();
            while (tempSearch != null)
            {
                tempParent = tempSearch;
                k = (Kisi)deger;
                k2 = (Kisi)tempSearch.veri;

                if (string.Compare(k.Ad, k2.Ad) == 0)
                    return;
                else if (string.Compare(k.Ad, k2.Ad) < 0)
                    tempSearch = tempSearch.sol;

                else
                    tempSearch = tempSearch.sag;
            }
            İkiliAramaAgacDugumu eklenecek = new İkiliAramaAgacDugumu(deger);
            if (kok == null)
                kok = eklenecek;
            else if (k.Ad.CompareTo(k2.Ad) < 0)
                tempParent.sol = eklenecek;
            else
                tempParent.sag = eklenecek;
        }
        public İkiliAramaAgacDugumu Ara(string anahtarAd)
        {
            return AraInt(kok, anahtarAd);
        }
        private İkiliAramaAgacDugumu AraInt(İkiliAramaAgacDugumu dugum, string anahtarAd)
        {
            if (dugum == null)
            {
                return null;
            }
            else
            {
                Kisi k = (Kisi)dugum.veri;
                if (string.Compare(k.Ad, anahtarAd) == 0)
                    return dugum;
                else if (string.Compare(k.Ad, anahtarAd) > 0)
                    return (AraInt(dugum.sol, anahtarAd));
                else
                    return (AraInt(dugum.sag, anahtarAd));
            }
        }

        private İkiliAramaAgacDugumu Successor(İkiliAramaAgacDugumu silDugum)
        {
            İkiliAramaAgacDugumu successorParent = silDugum;
            İkiliAramaAgacDugumu successor = silDugum;
            İkiliAramaAgacDugumu current = silDugum.sag;
            while (current != null)
            {
                successorParent = successor;
                successor = current;
                current = current.sol;
            }
            if (successor != silDugum.sag)
            {
                successorParent.sol = successor.sag;
                successor.sag = silDugum.sag;
            }
            return successor;
        }
        public bool Sil(int deger)
        {
            İkiliAramaAgacDugumu current = kok;
            İkiliAramaAgacDugumu parent = kok;
            bool issol = true;
            while ((int)current.veri != deger)
            {
                parent = current;
                if (deger < (int)current.veri)
                {
                    issol = true;
                    current = current.sol;
                }
                else
                {
                    issol = false;
                    current = current.sag;
                }
                if (current == null)
                    return false;
            }
            if (current.sol == null && current.sag == null)
            {
                if (current == kok)
                    kok = null;
                else if (issol)
                    parent.sol = null;
                else
                    parent.sag = null;
            }

            else if (current.sag == null)
            {
                if (current == kok)
                    kok = current.sol;
                else if (issol)
                    parent.sol = current.sol;
                else
                    parent.sag = current.sol;
            }
            else if (current.sol == null)
            {
                if (current == kok)
                    kok = current.sag;
                else if (issol)
                    parent.sol = current.sag;
                else
                    parent.sag = current.sag;
            }
            else
            {
                İkiliAramaAgacDugumu successor = Successor(current);
                if (current == kok)
                    kok = successor;
                else if (issol)
                    parent.sol = successor;
                else
                    parent.sag = successor;
                successor.sol = current.sol;
            }
            return true;
        }

    }
}

