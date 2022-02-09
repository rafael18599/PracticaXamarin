using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace DemoProyectoCrud.Datos
{
    public interface ISQLiteDB
    {
        SQLiteAsyncConnection GetConnection();
    }
}
