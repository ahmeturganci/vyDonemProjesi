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
        public IkiliArama()
        {
        }
        public IkiliArama(İkiliAramaAgacDugumu kok)
        {
            this.kok = kok;
        }
        public int DugumSayisi()
        {
            return DugumSayisi(kok);
        }
        private int DugumSayisi(İkiliAramaAgacDugumu dugum)
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
        private int YaprakSayisi(İkiliAramaAgacDugumu dugum)
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
        public int Derinlik()
        {
            return (Derinlik(kok));
        }
        private int Derinlik(İkiliAramaAgacDugumu kok)
        {
            if (kok == null)
                return 0;
            else
            {
                int solDerinlik = Derinlik(kok.sol);
                int sagDerinlik = Derinlik(kok.sag);
                if (solDerinlik > sagDerinlik)
                    return (solDerinlik + 1);
                else
                    return (sagDerinlik + 1);
            }
        }

        public string DugumleriYazdir()
        {
            return dugumler;
        }
        public void IngilizceBilenler()
        {
            dugumler = "";
            IngilizceBilenlerInt(kok);
        }
        private void IngilizceBilenlerInt(İkiliAramaAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            ZiyaretIngilizce(dugum);
            IngilizceBilenlerInt(dugum.sol);
            IngilizceBilenlerInt(dugum.sag);
        }
        public void OrtalamaListele()
        {
            dugumler = "";
            OrtalamaListeleInt(kok);
        }
        private void OrtalamaListeleInt(İkiliAramaAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            ZiyaretOrtalama(dugum);
            OrtalamaListeleInt(dugum.sol);
            OrtalamaListeleInt(dugum.sag);
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
            dugumler += dugum.veri.Ad + " " + dugum.veri.Adres + "" + dugum.veri.DogumTarihi + " " + dugum.veri.DogumYeri + " " + dugum.veri.egitimDurumu.MezunOlunanOkul + " " + dugum.veri.egitimDurumu.ortalama.ToString() + " " + dugum.veri.isYeri.Adi + " " + dugum.veri.isYeri.Gorev + Environment.NewLine;
        }
        private void ZiyaretIngilizce(İkiliAramaAgacDugumu dugum)
        {
            if (dugum.veri.YabanciDil == "ingilizce")
                dugumler += dugum.veri.Ad + " " + dugum.veri.Adres + "" + dugum.veri.DogumTarihi + " " + dugum.veri.DogumYeri + " " + dugum.veri.egitimDurumu.MezunOlunanOkul + " " + dugum.veri.egitimDurumu.ortalama.ToString() + " " + dugum.veri.isYeri.Adi + " " + dugum.veri.isYeri.Gorev + Environment.NewLine;
        }
        private void ZiyaretOrtalama(İkiliAramaAgacDugumu dugum)
        {
            if (dugum.veri.egitimDurumu.ortalama > 89)
                dugumler += dugum.veri.Ad + " " + dugum.veri.Adres + "" + dugum.veri.DogumTarihi + " " + dugum.veri.DogumYeri + " " + dugum.veri.egitimDurumu.MezunOlunanOkul + " " + dugum.veri.egitimDurumu.ortalama.ToString() + " " + dugum.veri.isYeri.Adi + " " + dugum.veri.isYeri.Gorev + Environment.NewLine;
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
        public void Ekle(Kisi deger)
        {
            İkiliAramaAgacDugumu tempParent = new İkiliAramaAgacDugumu();
            İkiliAramaAgacDugumu tempSearch = kok;
            while (tempSearch != null)
            {
                tempParent = tempSearch;
                if (string.Compare(deger.Ad, tempSearch.veri.Ad) == 0)
                    return;
                else if (string.Compare(deger.Ad, tempSearch.veri.Ad) < 0)
                    tempSearch = tempSearch.sol;

                else
                    tempSearch = tempSearch.sag;
            }
            İkiliAramaAgacDugumu eklenecek = new İkiliAramaAgacDugumu(deger);
            if (kok == null)
                kok = eklenecek;
            else if (deger.Ad.CompareTo(tempParent.veri.Ad) < 0)
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
        public bool Sil(İkiliAramaAgacDugumu deger)
        {
            İkiliAramaAgacDugumu current = kok;
            İkiliAramaAgacDugumu parent = kok;
            bool issol = true;
            //DÜĞÜMÜ BUL
            while ((current.veri.Ad.CompareTo(deger.veri.Ad) != 0))
            {
                parent = current;
                if (deger.veri.Ad.CompareTo(current.veri.Ad) < 0)
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
            //DURUM 1: YAPRAK DÜĞÜM
            if (current.sol == null && current.sag == null)
            {
                if (current == kok)
                    kok = null;
                else if (issol)
                    parent.sol = null;
                else
                    parent.sag = null;
            }
            //DURUM 2: TEK ÇOCUKLU DÜĞÜM
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
            //DURUM 3: İKİ ÇOCUKLU DÜĞÜM
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

