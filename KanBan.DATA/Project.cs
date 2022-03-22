using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanBan.DATA
{
    public class Project
    {
        public Project(string name)
        {
            Name = name;
            LastUpdateDate = CreatedDate = DateTime.Now;
            Notes = new List<Note>();
        }

        public string Name { get; set; }
        public List<Note> Notes { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
    }
}
