using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanBan.DATA
{
    public static class ProjectAdmin
    {
        public static void AddProject(string ad)
        {
            Project project = new Project(ad);
            project.isOpen = true;
            KanbanData.Projects.Add(project);
        }

        public static void DeleteProject(Project project)
        {
            KanbanData.Projects.Remove(project);
        }

        public static void AddNoteToProject(Project project, Note note)
        {
            project.Notes.Add(note);
        }


        public static void DeleteNoteFromProject(Project project, Note note)
        {
            project.Notes.Remove(note);
        }

        public static void AddCategory(Category category)
        {
            KanbanData.Categories.Add(category);
        }

        public static void DeleteCategory(Category category)
        {
            KanbanData.Categories.Remove(category);
        }
    }
}
