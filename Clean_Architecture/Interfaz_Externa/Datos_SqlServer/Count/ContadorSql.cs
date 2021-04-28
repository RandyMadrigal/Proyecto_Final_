using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Interfaz_Externa.Datos_SqlServer
{
    public class ContadorSql
    {

        ConectarSql objConexion = new ConectarSql();
        private SqlDataReader leer; //leer consultas, devuelve filas
        SqlCommand operacion = new SqlCommand(); //poder realizar procedimientos almacenados;

        public string Contador()
        {
            string dato = "-";

            operacion.Connection = objConexion.Abrir();
            operacion.CommandText = ("sp_Contador");
            operacion.CommandType = CommandType.StoredProcedure;
            leer = operacion.ExecuteReader(); //Devuelve Filas 

            if (leer.Read() )
            {
                dato = leer[""].ToString();
            }
            
            objConexion.Cerrar();

            return dato;
        }
    }
}
