﻿using System;
using System.Data;
using System.Data.SqlClient;

namespace Interfaz_Externa
{
    public class InsertarSql
    {
        ConectarSql objConexion = new ConectarSql();
        SqlCommand operacion = new SqlCommand(); //poder realizar procedimientos almacenados;
        DataTable tabla = new DataTable(); //Almacenar la consula realizada;

        public void InsertarDatosSql(string nombre)
        {
            operacion.Connection = objConexion.Abrir();
            operacion.CommandText = "sp_insertar";
            operacion.CommandType = CommandType.StoredProcedure;

            //Parametros que recibe el procedimiento almacenado
            operacion.Parameters.AddWithValue("@NOMBRE",nombre);

            //Parametros que recibe el procedimiento almacenado

            operacion.ExecuteNonQuery(); // realiza operacion de insert delete update

            //Se utiliza para eliminar el error que indica que se han utilizado muchos parametros
            //Por tanto limpiamos los parametros cada vez que se realiza una consulta.
            operacion.Parameters.Clear();

            operacion.Connection = objConexion.Cerrar();
        }


    }
}
