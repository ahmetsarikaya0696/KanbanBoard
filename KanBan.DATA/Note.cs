using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanBan.DATA
{
    public class Note
    {
        public Note()
        {
            Id = Guid.NewGuid();
            LastUpdateDate = CreatedDate = DateTime.Now;
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Icerik { get; set; }
        public StatuEnum Statu { get; set; }
        public Category Category { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public bool isNoteSavedOnce = false;
    }
}
