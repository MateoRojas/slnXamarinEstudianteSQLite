using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioClase
{
    class Medicina
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Marca { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}", Nombre, Marca);
        }
    }
}
