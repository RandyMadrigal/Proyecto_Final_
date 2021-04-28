using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaz_Externa;

namespace CasosDeUso.Adaptador_de_interfaz
{
    public class Actualizar
    {
        ActualizarSql ObjSql = new ActualizarSql();

        public void ActualizarDatos(int id,string texto)
        {
            ObjSql.ActualizarDatosSql(id, texto);
        }



    }
}
