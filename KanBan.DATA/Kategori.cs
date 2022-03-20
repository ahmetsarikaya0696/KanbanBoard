using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanBan.DATA
{
    public class Kategori
    {
        public Kategori(string ad, ConsoleColor renk)
        {
            Ad = ad;
            Renk = renk;
        }
        public string Ad { get; set; }
        public ConsoleColor Renk { get; set; }
    }
}
