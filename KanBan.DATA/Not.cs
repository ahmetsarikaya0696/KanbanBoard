using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanBan.DATA
{
    public class Not
    {
        public Not(string baslik, Kategori kategori)
        {
            Baslik = baslik;
            Kategori = kategori;
            SonGuncellenmeTarihi = OlusturulmaTarihi = DateTime.Now;
        }

        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public StatuEnum Statu { get; set; }
        public Kategori Kategori { get; set; }
        public DateTime OlusturulmaTarihi { get; set; }
        public DateTime SonGuncellenmeTarihi { get; set; }
    }
}
