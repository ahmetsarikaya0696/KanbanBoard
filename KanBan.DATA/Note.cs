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
            LastUpdateDate = CreatedDate = DateTime.Now;
        }

        public Note(string title, Category category)
        {
            Title = title;
            Category = category;
            LastUpdateDate = CreatedDate = DateTime.Now;
        }

        public string Title { get; set; }
        public string Icerik { get; set; }
        public StatuEnum Statu { get; set; }
        public Category Category { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
    }
}
