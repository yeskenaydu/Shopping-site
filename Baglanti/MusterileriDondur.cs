using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baglanti
{
    public class MusterileriDondur
    {
        SqlConnection baglanti;
        BaglantiNesnesiDondur baglantidondur = new BaglantiNesnesiDondur();
        
        public MusterileriDondur()
        {
            baglanti = baglantidondur.BaglantiDondur();
        }

        public DataTable MusteriSorgula(string numara)
        {
            SqlKomutlari komutstringi = new SqlKomutlari();
            baglanti.Open();
            DataTable musteri = new DataTable();
            SqlCommand Komut = komutstringi.Musteri(numara);
            Komut.Connection = baglanti;
            musteri.Load(Komut.ExecuteReader());
            baglanti.Close();
            return musteri;
        }
    }
}
