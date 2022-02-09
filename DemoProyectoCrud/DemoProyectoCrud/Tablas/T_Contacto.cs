using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace DemoProyectoCrud.Tablas
{
    class T_Contacto
    {
        [PrimaryKey,AutoIncrement]

        public int Id { get; set; }
        [MaxLength(255)]
        public string Nombre { get; set; }
        [MaxLength(255)]
        public string Apellido { get; set; }
        [MaxLength(255)]
        public string Telefono { get; set; }
    }
}
