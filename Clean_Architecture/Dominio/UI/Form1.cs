using System;
using System.Drawing;
using System.Windows.Forms;
using CasosDeUso.Casos_de_uso;

namespace Dominio
{
    public partial class VentanaPrincipal : Form
    {
        private Image ImagenInicio;
        Datos ObjCasosDeUso = new Datos();
        

        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
           ImagenInicio = Image.FromFile(@"UI\Imagen\git.gif");
           pictureBox1.Image = ImagenInicio;

            ContadorLabel.Text = ObjCasosDeUso.TIEMPO.ToString() + " SEG.";

            try 
            {
                Btn_iniciar.Enabled = false;
                MostrarTodosLosDatos();
                GetTurno();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        private void MostrarTodosLosDatos()
        {
            //Este objeto se utiliza para refrescar la consulta
            //en la que se muestran todos los datos de la tabla.
            CasosDeUso.Casos_de_uso.Datos ObjCasosDeUso2 = new CasosDeUso.Casos_de_uso.Datos();
            dataGridView1.DataSource = ObjCasosDeUso2.Enviar(); //Obtener los datos ya introducidos a la base de datos
        }

        private void GetTurno()
        {
            CasosDeUso.Casos_de_uso.Datos ObjCasosDeUso2 = new CasosDeUso.Casos_de_uso.Datos();
            TurnoBox1.Text = ObjCasosDeUso2.Contador(); //Obtener Turno
        }
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ObjCasosDeUso.Insertar(NombreBox.Text);
                MessageBox.Show("AGREGADO CON EXITO");
                Limpiar();
                MostrarTodosLosDatos();
                GetTurno();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }
       
        public void Limpiar()
        {
            NombreBox.Clear();
            NombreBox2.Clear();
            Num1Box.Clear();
            Num2Box.Clear();
            TurnoBox2.Clear();
            ResultadoBox.Clear();
        }

        private void DesactivarControles()
        {
            btnAgregar.Enabled = false;
            Btn_iniciar.Enabled = false;
            dataGridView1.Enabled = false;
        }

        private void ActivarControles()
        {
            btnAgregar.Enabled = true;
            Btn_iniciar.Enabled = true;
            dataGridView1.Enabled = true;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Btn_iniciar.Enabled = true;
                TurnoBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                NombreBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        private void Btn_iniciar_Click(object sender, EventArgs e)
        {
            try 
            {
                Cronometro.Enabled = true;
                
                Cronometro.Start();
                
                DesactivarControles();
                
                Num1Box.Text = ObjCasosDeUso.NUM1.ToString();
                
                Num2Box.Text = ObjCasosDeUso.NUM2.ToString();

            } catch (Exception ex) 
            {
                MessageBox.Show($"{ex}");
            }
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            string  parametro2;

            try
            {
                stop();

               MessageBox.Show($"{ObjCasosDeUso.Ganador(ResultadoBox.Text,Num1Box.Text, Num2Box.Text)}\n Resultado = {ObjCasosDeUso.Info(Num1Box.Text, Num2Box.Text)} " );

                TurnoBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString(); //Obtengo el ID DEL USUARIO QUE ESTA JUGANDO.
               
                parametro2 = ObjCasosDeUso.Ganador(ResultadoBox.Text, Num1Box.Text, Num2Box.Text); //Obtengo el texto, del usuairo que gano o perdio

                ObjCasosDeUso.Actualizar(TurnoBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString(), //Obtengo el ID DEL USUARIO QUE ESTA JUGANDO., 
                                            parametro2);

                Limpiar();

                ActivarControles();

                MostrarTodosLosDatos(); //Actualizar valores de la tabla.

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        private void Cronometro_Tick(object sender, EventArgs e)
        {

            try
            {
                ObjCasosDeUso.aumentar();
                ContadorLabel.Text = ObjCasosDeUso.TIEMPO.ToString() + " SEG.";
                BarraProgreso.Value = ObjCasosDeUso.TIEMPO;

                if (BarraProgreso.Value == 11)
                {
                    Cronometro.Stop();
                    BarraProgreso.Value = 0;
                    ObjCasosDeUso.Reset();
                    ContadorLabel.Text = ObjCasosDeUso.TIEMPO.ToString() + " SEG.";

                    Btn_iniciar.Enabled = false;

                    Limpiar();

                    dataGridView1.Enabled = true;

                    ObjCasosDeUso.Actualizar(TurnoBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString(),      //Obtengo el ID DEL USUARIO QUE ESTA JUGANDO., 
                                                                                                         "Perdedor");

                    MessageBox.Show($"Perdedor");

                    MostrarTodosLosDatos();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        public void stop()
        {
            Cronometro.Stop();
            BarraProgreso.Value = 0;
            ObjCasosDeUso.Reset();
            ContadorLabel.Text = ObjCasosDeUso.TIEMPO.ToString() + " SEG.";

        }
    }
}
