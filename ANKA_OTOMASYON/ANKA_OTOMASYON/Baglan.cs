using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace ANKA_OTOMASYON
{
    public class Baglan
    {
        public static SQLiteConnection connection = new SQLiteConnection("Data source=.\\database.db;Versiyon=3");
    }
}
