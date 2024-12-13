namespace Tarea___Semana_3.Libros
{
    partial class frmLibro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tntPorcentaje = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tntCdC = new System.Windows.Forms.TextBox();
            this.tntCI = new System.Windows.Forms.TextBox();
            this.txtNombreyApellido = new System.Windows.Forms.TextBox();
            this.tntDireccion = new System.Windows.Forms.TextBox();
            this.tntNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Tomato;
            this.button2.Location = new System.Drawing.Point(254, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 100);
            this.button2.TabIndex = 38;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(31, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 101);
            this.button1.TabIndex = 37;
            this.button1.Text = "Aplicar descuento";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tntPorcentaje
            // 
            this.tntPorcentaje.BackColor = System.Drawing.Color.Silver;
            this.tntPorcentaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tntPorcentaje.Location = new System.Drawing.Point(93, 244);
            this.tntPorcentaje.Name = "tntPorcentaje";
            this.tntPorcentaje.Size = new System.Drawing.Size(100, 13);
            this.tntPorcentaje.TabIndex = 36;
            this.tntPorcentaje.Text = "Formato";
            this.tntPorcentaje.TextChanged += new System.EventHandler(this.tntPorcentaje_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 265);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 20);
            this.textBox1.TabIndex = 35;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(93, 196);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(209, 20);
            this.textBox3.TabIndex = 34;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(308, 122);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 33;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(93, 122);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(209, 20);
            this.textBox2.TabIndex = 32;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tntCdC
            // 
            this.tntCdC.BackColor = System.Drawing.Color.Silver;
            this.tntCdC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tntCdC.Location = new System.Drawing.Point(93, 175);
            this.tntCdC.Name = "tntCdC";
            this.tntCdC.Size = new System.Drawing.Size(100, 13);
            this.tntCdC.TabIndex = 31;
            this.tntCdC.Text = "Autor";
            this.tntCdC.TextChanged += new System.EventHandler(this.tntCdC_TextChanged);
            // 
            // tntCI
            // 
            this.tntCI.BackColor = System.Drawing.Color.Silver;
            this.tntCI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tntCI.Location = new System.Drawing.Point(308, 102);
            this.tntCI.Name = "tntCI";
            this.tntCI.Size = new System.Drawing.Size(100, 13);
            this.tntCI.TabIndex = 30;
            this.tntCI.Text = "Valor";
            this.tntCI.TextChanged += new System.EventHandler(this.tntCI_TextChanged);
            // 
            // txtNombreyApellido
            // 
            this.txtNombreyApellido.BackColor = System.Drawing.Color.Silver;
            this.txtNombreyApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreyApellido.Location = new System.Drawing.Point(93, 32);
            this.txtNombreyApellido.Name = "txtNombreyApellido";
            this.txtNombreyApellido.Size = new System.Drawing.Size(100, 13);
            this.txtNombreyApellido.TabIndex = 29;
            this.txtNombreyApellido.Text = "Titulo del libro";
            this.txtNombreyApellido.TextChanged += new System.EventHandler(this.txtNombreyApellido_TextChanged);
            // 
            // tntDireccion
            // 
            this.tntDireccion.BackColor = System.Drawing.Color.Silver;
            this.tntDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tntDireccion.Location = new System.Drawing.Point(93, 102);
            this.tntDireccion.Name = "tntDireccion";
            this.tntDireccion.Size = new System.Drawing.Size(119, 13);
            this.tntDireccion.TabIndex = 28;
            this.tntDireccion.Text = "Año de publicacion";
            this.tntDireccion.TextChanged += new System.EventHandler(this.tntDireccion_TextChanged);
            // 
            // tntNombre
            // 
            this.tntNombre.Location = new System.Drawing.Point(93, 55);
            this.tntNombre.Name = "tntNombre";
            this.tntNombre.Size = new System.Drawing.Size(315, 20);
            this.tntNombre.TabIndex = 27;
            this.tntNombre.TextChanged += new System.EventHandler(this.tntNombre_TextChanged);
            // 
            // frmLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tntPorcentaje);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tntCdC);
            this.Controls.Add(this.tntCI);
            this.Controls.Add(this.txtNombreyApellido);
            this.Controls.Add(this.tntDireccion);
            this.Controls.Add(this.tntNombre);
            this.Name = "frmLibro";
            this.Text = "Agregar libro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tntPorcentaje;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox tntCdC;
        private System.Windows.Forms.TextBox tntCI;
        private System.Windows.Forms.TextBox txtNombreyApellido;
        private System.Windows.Forms.TextBox tntDireccion;
        private System.Windows.Forms.TextBox tntNombre;
    }
}