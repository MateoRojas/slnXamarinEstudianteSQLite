using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using SQLite.Net;
using Xamarin.Forms;

namespace EjercicioClase
{
    class Database:IDisposable
    {
        SQLiteConnection conn;

        public Database()
        {
            var config = DependencyService.Get<IConfig>();

            conn = new SQLiteConnection(config.Plataforma, Path.Combine(config.DirectorioDB, "dbMedicina.sqlite3"));
            conn.CreateTable<Medicina>();

        }

        public void IngresarMedicina(Medicina medicina)
        {
            conn.Insert(medicina);
        }

        public List<Medicina> ConsultarEstudiante()
        {
            return conn.Table<Medicina>().ToList();
        }

        public void Dispose()
        {
            conn.Dispose();
        }

    }
}
