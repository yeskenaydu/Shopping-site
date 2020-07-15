using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baglanti
{
    class BaglantiNesnesiDondur
    {
        BaglantiCumlesi baglantiCumlesi = new BaglantiCumlesi();
        SqlConnection baglanti;
        public BaglantiNesnesiDondur()
        {
            baglanti = new SqlConnection(baglantiCumlesi.BaglantiStringiDondur());
        }

        public SqlConnection BaglantiDondur()
        {
            return baglanti;
        }
    }
}
