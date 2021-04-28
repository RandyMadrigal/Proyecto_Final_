using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Interfaz_Externa
{
    public class MostrarSql
    {
        ConectarSql objConexion = new ConectarSql();
        private SqlDataReader leer; //leer consultas, devuelve filas
        SqlCommand operacion = new SqlCommand(); //poder realizar procedimientos almacenados;
        DataTable tabla = new DataTable(); //Almacenar la consula realizada;

        public DataTable MostrarTodosLosDatosSql()
        {
            operacion.Connection = objConexion.Abrir();
            operacion.CommandText = "sp_mostrar"; //Procedimiento almacenado
            operacion.CommandType = CommandType.StoredProcedure;
            leer = operacion.ExecuteReader(); //Devuelve Filas 
            tabla.Load(leer);
            objConexion.Cerrar();

            return tabla;
        }



    }
}
