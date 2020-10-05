using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adatbazis_kerdesek
{
    class Kerdes
    {
        string db;
        string szoveg;

        public string Db { get => db; }
        public string Szoveg { get => szoveg; }

        public Kerdes(string db, string szoveg)
        {
            this.db = db;
            this.szoveg = szoveg;
        }
    }
}
