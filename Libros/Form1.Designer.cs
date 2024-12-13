namespace Tarea___Semana_3.Libros
{
    partial class frmNvTienda
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tntNombre = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtNombreyApellido = new System.Windows.Forms.TextBox();
            this.tntDireccion = new System.Windows.Forms.TextBox();
            this.tntProvincia = new System.Windows.Forms.TextBox();
            this.tntCP = new System.Windows.Forms.TextBox();
            this.tntPais = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(-3, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 101);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(254, 327);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(41, 328);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 8;
            // 
            // tntNombre
            // 
            this.tntNombre.Location = new System.Drawing.Point(104, 57);
            this.tntNombre.Name = "tntNombre";
            this.tntNombre.Size = new System.Drawing.Size(315, 20);
            this.tntNombre.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Tomato;
            this.button2.Location = new System.Drawing.Point(254, 327);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 100);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(104, 112);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(209, 20);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(104, 164);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(209, 20);
            this.textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(104, 216);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(209, 20);
            this.textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(319, 112);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 13;
            // 
            // txtNombreyApellido
            // 
            this.txtNombreyApellido.BackColor = System.Drawing.Color.Silver;
            this.txtNombreyApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreyApellido.Location = new System.Drawing.Point(104, 31);
            this.txtNombreyApellido.Name = "txtNombreyApellido";
            this.txtNombreyApellido.Size = new System.Drawing.Size(100, 13);
            this.txtNombreyApellido.TabIndex = 14;
            this.txtNombreyApellido.Text = "Nombre y apellido";
            this.txtNombreyApellido.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // tntDireccion
            // 
            this.tntDireccion.BackColor = System.Drawing.Color.Silver;
            this.tntDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tntDireccion.Location = new System.Drawing.Point(104, 86);
            this.tntDireccion.Name = "tntDireccion";
            this.tntDireccion.Size = new System.Drawing.Size(119, 13);
            this.tntDireccion.TabIndex = 15;
            this.tntDireccion.Text = "Direccion";
            // 
            // tntProvincia
            // 
            this.tntProvincia.BackColor = System.Drawing.Color.Silver;
            this.tntProvincia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tntProvincia.Location = new System.Drawing.Point(104, 138);
            this.tntProvincia.Name = "tntProvincia";
            this.tntProvincia.Size = new System.Drawing.Size(100, 13);
            this.tntProvincia.TabIndex = 16;
            this.tntProvincia.Text = "Provincia";
            // 
            // tntCP
            // 
            this.tntCP.BackColor = System.Drawing.Color.Silver;
            this.tntCP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tntCP.Location = new System.Drawing.Point(319, 86);
            this.tntCP.Name = "tntCP";
            this.tntCP.Size = new System.Drawing.Size(100, 13);
            this.tntCP.TabIndex = 17;
            this.tntCP.Text = "Codigo postal";
            // 
            // tntPais
            // 
            this.tntPais.BackColor = System.Drawing.Color.Silver;
            this.tntPais.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tntPais.Location = new System.Drawing.Point(104, 190);
            this.tntPais.Name = "tntPais";
            this.tntPais.Size = new System.Drawing.Size(100, 13);
            this.tntPais.TabIndex = 18;
            this.tntPais.Text = "Pais";
            // 
            // frmNvTienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tntPais);
            this.Controls.Add(this.tntCP);
            this.Controls.Add(this.tntProvincia);
            this.Controls.Add(this.tntDireccion);
            this.Controls.Add(this.txtNombreyApellido);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tntNombre);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmNvTienda";
            this.Text = "Nueva Tienda";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tntNombre;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txtNombreyApellido;
        private System.Windows.Forms.TextBox tntDireccion;
        private System.Windows.Forms.TextBox tntProvincia;
        private System.Windows.Forms.TextBox tntCP;
        private System.Windows.Forms.TextBox tntPais;
    }
}