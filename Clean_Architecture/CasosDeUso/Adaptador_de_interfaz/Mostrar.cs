using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaz_Externa;
using System.Data;


namespace CasosDeUso.Adaptador_de_interfaz
{
    public class Mostrar
    {
        MostrarSql  ObjSql = new MostrarSql();
            

        //ALMACENA LA CONSULTA REALIZADA EN LA CAPA DE DATOS, para mostrar TODOS LOS DATOS DE LA BASE DE DATOS
        public DataTable MostrarTodosLosDatos()
        {
            DataTable tabla = new DataTable();

            tabla = ObjSql.MostrarTodosLosDatosSql();

            return tabla;
            //ALMACENA LA CONSULTA REALIZADA EN LA CAPA DE DATOS, para mostrar TODOS LOS DATOS DE LA BASE DE DATOS
        }

    }
}
