using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modeller
{

    public class UrunListesi
    {
        public List<Urun> UrunListe = new List<Urun>();
    }

    public class Urun
    {
        public int urunID;
        public string isim;
        public string marka;
        public string ucret;
        public string kategori;
        public string resimYolu;
        public string aciklama;
    }

}