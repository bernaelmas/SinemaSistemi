using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinema.Sinif
{
    public class Sinema
    {
        int ToplamKoltukSayisi { get; set; }
        int BosKoltukSayisi;
        double Bakiye;
        string SalonNo;

        List<int> SatilanKoltuklar = new List<int>();
        List<int> BosKoltuklar = new List<int>();

        const double Tam = 15;
        const double Indirimli = 10;

        public Sinema (string SalonNo, int koltukSayisi) 
        {
            this.ToplamKoltukSayisi = koltukSayisi;
            this.SalonNo = SalonNo;
            this.BosKoltukSayisi= this.ToplamKoltukSayisi;
            this.Bakiye = 0;
             for (int i = 1; i <= koltukSayisi; i++)
            {
                this.BosKoltuklar.Add(i);
            }
            
        }

        public string BiletSat(bool durum, int KoltukNo)
        {
            if (this.BosKoltukSayisi > 0 && this.BosKoltuklar.Contains(KoltukNo))
            {
                BosKoltukSayisi--;
                if (durum == true)
                {
                    this.Bakiye += Indirimli;
                }
                else
                {
                    this.Bakiye += Tam;
                }
                this.BosKoltuklar.Remove(KoltukNo);
                this.SatilanKoltuklar.Add(KoltukNo);
                return KoltukNo.ToString() + " Numaralı Koltuk Başarıyla Satıldı.";
            }
            return KoltukNo.ToString() + " Numaralı Koltuk Doludur!";
        }

        public string BiletIptal(bool durum, int KoltukNo)
        {
            if (this.ToplamKoltukSayisi != this.BosKoltukSayisi && this.SatilanKoltuklar.Contains(KoltukNo))
            {
                BosKoltukSayisi++;
                if (durum == true)
                {
                    this.Bakiye -= Indirimli;
                }
                else
                {
                    this.Bakiye -= Tam;
                }
                this.BosKoltuklar.Add(KoltukNo);
                this.SatilanKoltuklar.Remove(KoltukNo);
                return KoltukNo.ToString() + " Numaralı Koltuk Başarıyla İade Edildi.";
            }
            return KoltukNo.ToString() + " Numaralı Koltuk Zaten Boştur!";
        }

        public string BosKoltukOgren()
        {
            this.BosKoltuklar.Sort();
            string mesaj = "";
            for(int i = 0; i < this.BosKoltuklar.Count; i++)
            {
                mesaj = mesaj + " " + this.BosKoltuklar[i];
            }
            return mesaj;
        }

        public double BakiyeOgren()
        {
            return this.Bakiye;
        }

        public string SalonAdiOgren()
        {
            return this.SalonNo;
        }

        public string BosKoltukSayisiOgren()
        {
            return this.BosKoltukSayisi.ToString();
        }
    }
}
