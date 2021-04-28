
namespace Dominio
{
    partial class VentanaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TituloLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NombreBox = new System.Windows.Forms.TextBox();
            this.TurnoBox1 = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.TurnoLabel = new System.Windows.Forms.Label();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.Titulo2Label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TurnoBox2 = new System.Windows.Forms.TextBox();
            this.Btn_iniciar = new System.Windows.Forms.Button();
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.ResultadoBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Num2Box = new System.Windows.Forms.TextBox();
            this.Num1Box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NombreBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Cronometro = new System.Windows.Forms.Timer(this.components);
            this.BarraProgreso = new System.Windows.Forms.ProgressBar();
            this.ContadorLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TituloLabel
            // 
            this.TituloLabel.AutoSize = true;
            this.TituloLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TituloLabel.Location = new System.Drawing.Point(458, 19);
            this.TituloLabel.Name = "TituloLabel";
            this.TituloLabel.Size = new System.Drawing.Size(369, 33);
            this.TituloLabel.TabIndex = 0;
            this.TituloLabel.Text = "TABLA DE RESULTADOS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.NombreBox);
            this.panel1.Controls.Add(this.TurnoBox1);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.TurnoLabel);
            this.panel1.Controls.Add(this.NombreLabel);
            this.panel1.Controls.Add(this.Titulo2Label);
            this.panel1.Location = new System.Drawing.Point(27, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 216);
            this.panel1.TabIndex = 1;
            // 
            // NombreBox
            // 
            this.NombreBox.Location = new System.Drawing.Point(111, 95);
            this.NombreBox.Name = "NombreBox";
            this.NombreBox.Size = new System.Drawing.Size(177, 26);
            this.NombreBox.TabIndex = 9;
            // 
            // TurnoBox1
            // 
            this.TurnoBox1.Location = new System.Drawing.Point(111, 49);
            this.TurnoBox1.Name = "TurnoBox1";
            this.TurnoBox1.Size = new System.Drawing.Size(45, 26);
            this.TurnoBox1.TabIndex = 8;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(111, 141);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(127, 38);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // TurnoLabel
            // 
            this.TurnoLabel.AutoSize = true;
            this.TurnoLabel.ForeColor = System.Drawing.Color.White;
            this.TurnoLabel.Location = new System.Drawing.Point(20, 52);
            this.TurnoLabel.Name = "TurnoLabel";
            this.TurnoLabel.Size = new System.Drawing.Size(60, 18);
            this.TurnoLabel.TabIndex = 2;
            this.TurnoLabel.Text = "Turno:";
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.ForeColor = System.Drawing.Color.White;
            this.NombreLabel.Location = new System.Drawing.Point(20, 98);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(76, 18);
            this.NombreLabel.TabIndex = 1;
            this.NombreLabel.Text = "Nombre:";
            // 
            // Titulo2Label
            // 
            this.Titulo2Label.AutoSize = true;
            this.Titulo2Label.BackColor = System.Drawing.Color.Transparent;
            this.Titulo2Label.ForeColor = System.Drawing.Color.White;
            this.Titulo2Label.Location = new System.Drawing.Point(80, 11);
            this.Titulo2Label.Name = "Titulo2Label";
            this.Titulo2Label.Size = new System.Drawing.Size(150, 18);
            this.Titulo2Label.TabIndex = 0;
            this.Titulo2Label.Text = "Ingrese sus datos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(381, 65);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(520, 398);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 122);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.TurnoBox2);
            this.panel2.Controls.Add(this.Btn_iniciar);
            this.panel2.Controls.Add(this.BtnConfirmar);
            this.panel2.Controls.Add(this.ResultadoBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Num2Box);
            this.panel2.Controls.Add(this.Num1Box);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.NombreBox2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(907, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 216);
            this.panel2.TabIndex = 5;
            // 
            // TurnoBox2
            // 
            this.TurnoBox2.Location = new System.Drawing.Point(165, 9);
            this.TurnoBox2.Name = "TurnoBox2";
            this.TurnoBox2.Size = new System.Drawing.Size(37, 26);
            this.TurnoBox2.TabIndex = 8;
            this.TurnoBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Btn_iniciar
            // 
            this.Btn_iniciar.Location = new System.Drawing.Point(20, 175);
            this.Btn_iniciar.Name = "Btn_iniciar";
            this.Btn_iniciar.Size = new System.Drawing.Size(88, 28);
            this.Btn_iniciar.TabIndex = 6;
            this.Btn_iniciar.Text = "iniciar";
            this.Btn_iniciar.UseVisualStyleBackColor = true;
            this.Btn_iniciar.Click += new System.EventHandler(this.Btn_iniciar_Click);
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.Location = new System.Drawing.Point(201, 129);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(102, 28);
            this.BtnConfirmar.TabIndex = 7;
            this.BtnConfirmar.Text = "Confirmar";
            this.BtnConfirmar.UseVisualStyleBackColor = true;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // ResultadoBox
            // 
            this.ResultadoBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultadoBox.Location = new System.Drawing.Point(201, 88);
            this.ResultadoBox.Name = "ResultadoBox";
            this.ResultadoBox.Size = new System.Drawing.Size(86, 26);
            this.ResultadoBox.TabIndex = 6;
            this.ResultadoBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(177, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "=";
            // 
            // Num2Box
            // 
            this.Num2Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Num2Box.Location = new System.Drawing.Point(114, 88);
            this.Num2Box.Name = "Num2Box";
            this.Num2Box.Size = new System.Drawing.Size(55, 26);
            this.Num2Box.TabIndex = 4;
            this.Num2Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Num1Box
            // 
            this.Num1Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Num1Box.Location = new System.Drawing.Point(32, 88);
            this.Num1Box.Name = "Num1Box";
            this.Num1Box.Size = new System.Drawing.Size(55, 26);
            this.Num1Box.TabIndex = 3;
            this.Num1Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(78, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quiz";
            // 
            // NombreBox2
            // 
            this.NombreBox2.Location = new System.Drawing.Point(208, 9);
            this.NombreBox2.Name = "NombreBox2";
            this.NombreBox2.Size = new System.Drawing.Size(130, 26);
            this.NombreBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(93, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "*";
            // 
            // Cronometro
            // 
            this.Cronometro.Interval = 1000;
            this.Cronometro.Tick += new System.EventHandler(this.Cronometro_Tick);
            // 
            // BarraProgreso
            // 
            this.BarraProgreso.Location = new System.Drawing.Point(1021, 368);
            this.BarraProgreso.Maximum = 11;
            this.BarraProgreso.Name = "BarraProgreso";
            this.BarraProgreso.Size = new System.Drawing.Size(143, 23);
            this.BarraProgreso.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.BarraProgreso.TabIndex = 6;
            // 
            // ContadorLabel
            // 
            this.ContadorLabel.AutoSize = true;
            this.ContadorLabel.Location = new System.Drawing.Point(1072, 398);
            this.ContadorLabel.Name = "ContadorLabel";
            this.ContadorLabel.Size = new System.Drawing.Size(56, 18);
            this.ContadorLabel.TabIndex = 7;
            this.ContadorLabel.Text = "label4";
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(1265, 485);
            this.Controls.Add(this.ContadorLabel);
            this.Controls.Add(this.BarraProgreso);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TituloLabel);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VentanaPrincipal";
            this.Text = "App de turno";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TituloLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TurnoLabel;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.Label Titulo2Label;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox NombreBox;
        private System.Windows.Forms.TextBox TurnoBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Num1Box;
        private System.Windows.Forms.TextBox NombreBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.TextBox ResultadoBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Num2Box;
        private System.Windows.Forms.Button Btn_iniciar;
        private System.Windows.Forms.TextBox TurnoBox2;
        private System.Windows.Forms.Timer Cronometro;
        private System.Windows.Forms.ProgressBar BarraProgreso;
        private System.Windows.Forms.Label ContadorLabel;
    }
}

