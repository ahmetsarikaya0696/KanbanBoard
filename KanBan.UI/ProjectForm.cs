﻿using KanBan.DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanBan.UI
{
    public partial class ProjectForm : Form
    {
        private Proje proje;

        public ProjectForm(Proje proje)
        {
            this.proje = proje;
            InitializeComponent();
            lblToDo.Width = lblDoing.Width = lblDone.Width = flpToDo.Width = flpDoing.Width = flpDone.Width = ClientSize.Width;
            flpToDo.Height = flpDoing.Height = flpDone.Height = ClientSize.Height;
            this.Text = proje.Ad;
        }

        private void tsmiAddNote_Click(object sender, EventArgs e)
        {
            Not not = new Not();
            
            ProjeYoneticisi.ProjeyeNotEkle(proje, not);

            flpToDo.Controls.Add(new NotePreview(not, proje) { Width = flpToDo.Width - 10, Height = (flpToDo.Width - 10) / 2 });

        }

        private void flpToDo_DragEnter(object sender, DragEventArgs e)
        {
            DragEnterMetot(e);
        }

        private void flpDoing_DragEnter(object sender, DragEventArgs e)
        {
            DragEnterMetot(e);
        }

        private void flpDone_DragEnter(object sender, DragEventArgs e)
        {
            DragEnterMetot(e);
        }

        private void flpToDo_DragDrop(object sender, DragEventArgs e)
        {
            DragDropMetot(sender, e);
        }

        private void flpDoing_DragDrop(object sender, DragEventArgs e)
        {
            DragDropMetot(sender, e);
        }

        private void flpDone_DragDrop(object sender, DragEventArgs e)
        {
            DragDropMetot(sender, e);
        }

        private void DragDropMetot(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(typeof(string)))
                return;

            var name = e.Data.GetData(typeof(string)) as string;
            //var ctr = this.Controls.Find(name, true).FirstOrDefault();
            //var ctr = this.Controls.Find(name, true).Where(x => ((NotePreview)x).BackColor == Color.Blue).FirstOrDefault();
            var ctr = this.Controls.Find(name, true).Where(x => ((NotePreview)x).Secilimi == true).FirstOrDefault();
            if (ctr != null)
            {
                ctr.Parent.Controls.Remove(ctr);
                var panel = sender as FlowLayoutPanel;
                ((FlowLayoutPanel)sender).Controls.Add(ctr);
            }
        }

        private static void DragEnterMetot(DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }


    }
}
