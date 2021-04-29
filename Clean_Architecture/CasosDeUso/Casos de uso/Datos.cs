using System;
using System.Data;
using CasosDeUso.Adaptador_de_interfaz;

namespace CasosDeUso.Casos_de_uso
{
   public class Datos
    {
        Adaptador ObjAdaptador = new Adaptador();

        //datos
        private int Id;
        private string Nombre;

        //game
        private Random aleatorio = new Random();
        private int Num1;
        private int Num2;
        private int resultado;
        
        //timer
        private int tiempo;
        private bool inicio;


        public Datos() { tiempo = 0; }

        public int ID
        {
            get { return Id; }
            set { Id = value; }
        }
        public string NOMBRE {
            get { return Nombre; }
            set { Nombre = value; }
        }

    
        /////////////////////////
        public DataTable Enviar()
        {
            return ObjAdaptador.MostrarTodosLosDatos();
        }

        public string Contador()
        {
            return ObjAdaptador.GetId();
        }
        
        public void Insertar(string nombre)
        {
            ObjAdaptador.InsertarDatos(NOMBRE = nombre);
        }

        public void Actualizar(string id, string texto)
        {
            ObjAdaptador.ActualizarDatos( int.Parse(id), texto);
        }

        ///// Quiz
        public int NUM1
        {
            get { return Num1 = aleatorio.Next(0, 10); }
            set { Num1 = value; }
        }

        public int NUM2
        {
            get { return Num2 = aleatorio.Next(0, 10);  }
            set { Num2 = value; }
        }

        public int RESULTADO
        {
            get { return resultado; }
            set { resultado = value; }
        }

        public string Ganador(string resultado,string num1,string num2)
        {
            string texto;
            
            if( int.Parse(resultado) == int.Parse(num1) * int.Parse(num2) )
            {
                texto = "Ganador";

                return texto;
            }
            
            texto = "Perdedor";

            return texto;
        }

        public string Info(string num1, string num2)
        {
            RESULTADO = int.Parse(num1) * int.Parse(num2);

            return RESULTADO.ToString();
        }
        ///// Quiz


        ///Timer
        public int TIEMPO
        {
            get { return tiempo; }
            set { tiempo = value; }
        }

        public bool INICIO
        {
            get { return inicio; }
            set { inicio = value; }
        }

        public void Reset()
        {
            TIEMPO = 0;
            
        }

        public void aumentar()
        {
            TIEMPO++;
        }
        //TIMER

    }
}
