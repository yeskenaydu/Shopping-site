using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baglanti;
using System.Data;

namespace Modeller
{
    public class Musteri
    {
        public string isim;
        public string soyisim;
        public string numara;
        public string mail;
        public string id;
    }

    class MusteriListesi
    {
        public List<Musteri> MusteriListe = new List<Musteri>();
    }

    public class MusteriDondur
    {
        Musteri musteri = new Musteri();
        Baglanti.MusterileriDondur musteriDondur = new MusterileriDondur();
        DataTable musteriTablosu = new DataTable();
        private string numara;

        public MusteriDondur(string numara)
        {
            musteriTablosu = musteriDondur.MusteriSorgula(numara);
        }

        

        public Musteri musteriElemani()
        {

            if (musteriTablosu.Rows.Count > 0)
            {
                musteri.isim = musteriTablosu.Rows[0]["Isim"].ToString();
                musteri.numara = musteriTablosu.Rows[0]["Numara"].ToString();
                musteri.soyisim = musteriTablosu.Rows[0]["Soyisim"].ToString();
                musteri.mail = musteriTablosu.Rows[0]["Mail"].ToString();
                musteri.id = musteriTablosu.Rows[0]["MusteriID"].ToString();
                return musteri;
            }
            else
                return null;
        }
    }
}
