using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Interfaz_Externa.Datos_SqlServer;

namespace CasosDeUso.Adaptador_de_interfaz
{
    public class Contador
    {
        ContadorSql ObjSql = new ContadorSql();

        //ALMACENA LA CONSULTA REALIZADA EN LA CAPA DE DATOS, para mostrar TODOS LOS DATOS DE LA BASE DE DATOS
        public string GetId()
        {
           string dato = ObjSql.Contador();

            return dato;
            //ALMACENA LA CONSULTA REALIZADA EN LA CAPA DE DATOS, para mostrar TODOS LOS DATOS DE LA BASE DE DATOS
        }
    }
}
