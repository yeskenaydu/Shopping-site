using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baglanti
{
    public class UrunleriDondur
    {
        SqlConnection baglanti;
        BaglantiNesnesiDondur baglantidondur = new BaglantiNesnesiDondur();
        
        public UrunleriDondur()
        {
            baglanti = baglantidondur.BaglantiDondur();
        }

        public DataTable ButunUrunleriDondur()
        {
            SqlKomutlari komutStringi = new SqlKomutlari();
            baglanti.Open();
            DataTable Elemanlar = new DataTable();
            SqlCommand Komut = new SqlCommand(komutStringi.ButunElemanlar, baglanti);
            Elemanlar.Load(Komut.ExecuteReader());
            baglanti.Close();
            return Elemanlar;
            
        }

        public DataTable TeknolojiUtunleriDondur()
        {
            SqlKomutlari komutStringi = new SqlKomutlari();
            baglanti.Open();
            DataTable Elemanlar = new DataTable();
            SqlCommand Komut = new SqlCommand(komutStringi.ElektronikElemanlar, baglanti);
            Elemanlar.Load(Komut.ExecuteReader());
            baglanti.Close();
            return Elemanlar;

        }

        public DataTable KitapUrunleriDondur()
        {
            SqlKomutlari komutStringi = new SqlKomutlari();
            baglanti.Open();
            DataTable Elemanlar = new DataTable();
            SqlCommand Komut = new SqlCommand(komutStringi.KitapElemanlar, baglanti);
            Elemanlar.Load(Komut.ExecuteReader());
            baglanti.Close();
            return Elemanlar;

        }

        public DataTable GiyimUrunleriDondur()
        {
            SqlKomutlari komutStringi = new SqlKomutlari();
            baglanti.Open();
            DataTable Elemanlar = new DataTable();
            SqlCommand Komut = new SqlCommand(komutStringi.GiyimElemanlar, baglanti);
            Elemanlar.Load(Komut.ExecuteReader());
            baglanti.Close();
            return Elemanlar;

        }
    }
}
