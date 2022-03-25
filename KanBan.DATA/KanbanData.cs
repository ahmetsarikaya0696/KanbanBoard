using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanBan.DATA
{
    public static class KanbanData
    {
        public static BindingList<Project> Projects { get; set; } = new BindingList<Project>();
        public static BindingList<Category> Categories { get; set; } = new BindingList<Category>();

    }
}
