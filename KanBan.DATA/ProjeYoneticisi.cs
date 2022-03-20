using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanBan.DATA
{
    public static class ProjeYoneticisi
    {
        public static void ProjeEkle(string ad)
        {
            Proje proje = new Proje(ad);
            Veriler.Projeler.Add(proje);
        }

        public static void ProjeSil(Proje proje)
        {
            Veriler.Projeler.Remove(proje);
        }

        public static void ProjeyeNotEkle(Proje proje, Not not)
        {
            proje.Notlar.Add(not);
        }


        public static void ProjedenNotSil(Proje proje, Not not)
        {
            proje.Notlar.Remove(not);
        }

        public static void KategoriEkle(string kategoriAdı, ConsoleColor kategoriRengi)
        {
            Kategori kategori = new Kategori(kategoriAdı, kategoriRengi);
            Veriler.Kategoriler.Add(kategori);
        }

        public static void KategoriSil(Kategori kategori)
        {
            Veriler.Kategoriler.Remove(kategori);
        }
    }
}
