using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaz_Externa;

namespace CasosDeUso.Adaptador_de_interfaz
{
    public class Insertar
    {
        InsertarSql ObjSql = new InsertarSql();
        
        public void InsertarDatos(string nombre)
        {
            ObjSql.InsertarDatosSql(nombre);
        }
        


    }
}
