using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanBan.DATA
{
    public class Proje
    {
        public Proje(string ad)
        {
            Ad = ad;
            SonGuncellenmeTarihi = OlusturulmaTarihi = DateTime.Now;
            Durum = DurumEnum.DevamEdiyor;
            Notlar = new List<Not>();
        }

        public string Ad { get; set; }
        public DurumEnum Durum { get; set; }
        public List<Not> Notlar { get; set; }
        public DateTime OlusturulmaTarihi { get; set; }
        public DateTime SonGuncellenmeTarihi { get; set; }
    }
}
