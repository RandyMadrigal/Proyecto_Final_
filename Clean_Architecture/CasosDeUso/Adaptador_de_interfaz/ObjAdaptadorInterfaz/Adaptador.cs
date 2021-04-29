using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Interfaz_Externa;
using Interfaz_Externa.Datos_SqlServer;

namespace CasosDeUso.Adaptador_de_interfaz
{
    class Adaptador : Imostrar , IActualizar , IContador , Iinsertar
    {

        ActualizarSql ObjSqlActualizar = new ActualizarSql();
        MostrarSql ObjSqlMostrar = new MostrarSql();
        InsertarSql ObjSqlInsertar = new InsertarSql();
        ContadorSql ObjSqlContador = new ContadorSql();

        public void ActualizarDatos(int id, string texto)
        {
            ObjSqlActualizar.ActualizarDatosSql(id, texto);

        }

        public string GetId()
        {
            string dato = ObjSqlContador.Contador();

            return dato;
            //ALMACENA LA CONSULTA, PARA ALMACENAR EL ID 
        }

        public void InsertarDatos(string nombre)
        {
            ObjSqlInsertar.InsertarDatosSql(nombre);

        }

        public DataTable MostrarTodosLosDatos()
        {
            DataTable tabla = new DataTable();

            tabla = ObjSqlMostrar.MostrarTodosLosDatosSql();

            return tabla;
            //ALMACENA LA CONSULTA REALIZADA, para mostrar TODOS LOS DATOS DE LA BASE DE DATOS

        }
    }
}
