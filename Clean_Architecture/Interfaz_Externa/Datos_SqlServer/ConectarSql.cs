using System;
using System.Data;
using System.Data.SqlClient;

namespace Interfaz_Externa
{
    public class ConectarSql
    {
        private SqlConnection Conexion = new SqlConnection("Server=(local);DataBase= Programacion2; Integrated Security = true");

        public SqlConnection Abrir()
        {
            if (Conexion.State == ConnectionState.Closed)
            {
                Conexion.Open();
            }
            return Conexion;
        }

        public SqlConnection Cerrar()
        {

            if (Conexion.State == ConnectionState.Open)
            {
                Conexion.Close();
            }
            return Conexion;
        }

    }
}
