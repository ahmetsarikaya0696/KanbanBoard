using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanBan.DATA
{
    public static class Veriler
    {
        public static int FormAdet { get; set; }
        public static List<Form> AktifFormList { get; set; } = new List<Form>();
        public static List<Form> PasifFormList { get; set; } = new List<Form>();
    }
}
