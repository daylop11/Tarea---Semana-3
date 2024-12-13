namespace Tarea___Semana_3.Ventas
{
    partial class frmVentas
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
            this.tntNombre = new System.Windows.Forms.TextBox();
            this.tntDireccion = new System.Windows.Forms.TextBox();
            this.txtNombreyApellido = new System.Windows.Forms.TextBox();
            this.tntCI = new System.Windows.Forms.TextBox();
            this.tntCdC = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tntPorcentaje = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tntNombre
            // 
            this.tntNombre.Location = new System.Drawing.Point(92, 51);
            this.tntNombre.Name = "tntNombre";
            this.tntNombre.Size = new System.Drawing.Size(315, 20);
            this.tntNombre.TabIndex = 10;
            // 
            // tntDireccion
            // 
            this.tntDireccion.BackColor = System.Drawing.Color.Silver;
            this.tntDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tntDireccion.Location = new System.Drawing.Point(92, 98);
            this.tntDireccion.Name = "tntDireccion";
            this.tntDireccion.Size = new System.Drawing.Size(119, 13);
            this.tntDireccion.TabIndex = 16;
            this.tntDireccion.Text = "Direccion";
            // 
            // txtNombreyApellido
            // 
            this.txtNombreyApellido.BackColor = System.Drawing.Color.Silver;
            this.txtNombreyApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreyApellido.Location = new System.Drawing.Point(92, 28);
            this.txtNombreyApellido.Name = "txtNombreyApellido";
            this.txtNombreyApellido.Size = new System.Drawing.Size(100, 13);
            this.txtNombreyApellido.TabIndex = 17;
            this.txtNombreyApellido.Text = "Nombre y apellido";
            // 
            // tntCI
            // 
            this.tntCI.BackColor = System.Drawing.Color.Silver;
            this.tntCI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tntCI.Location = new System.Drawing.Point(307, 98);
            this.tntCI.Name = "tntCI";
            this.tntCI.Size = new System.Drawing.Size(100, 13);
            this.tntCI.TabIndex = 18;
            this.tntCI.Text = "Codigo de identidad";
            // 
            // tntCdC
            // 
            this.tntCdC.BackColor = System.Drawing.Color.Silver;
            this.tntCdC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tntCdC.Location = new System.Drawing.Point(92, 171);
            this.tntCdC.Name = "tntCdC";
            this.tntCdC.Size = new System.Drawing.Size(100, 13);
            this.tntCdC.TabIndex = 19;
            this.tntCdC.Text = "Codigo de compra";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(92, 118);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(209, 20);
            this.textBox2.TabIndex = 20;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(307, 118);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 21;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(92, 192);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(209, 20);
            this.textBox3.TabIndex = 22;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 261);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 20);
            this.textBox1.TabIndex = 23;
            // 
            // tntPorcentaje
            // 
            this.tntPorcentaje.BackColor = System.Drawing.Color.Silver;
            this.tntPorcentaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tntPorcentaje.Location = new System.Drawing.Point(92, 240);
            this.tntPorcentaje.Name = "tntPorcentaje";
            this.tntPorcentaje.Size = new System.Drawing.Size(100, 13);
            this.tntPorcentaje.TabIndex = 24;
            this.tntPorcentaje.Text = "Pocentaje aplicado";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(30, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 101);
            this.button1.TabIndex = 25;
            this.button1.Text = "Aplicar descuento";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Tomato;
            this.button2.Location = new System.Drawing.Point(253, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 100);
            this.button2.TabIndex = 26;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // frmVentas
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmVentas";
            this.Text = "Descuentos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tntNombre;
        private System.Windows.Forms.TextBox tntDireccion;
        private System.Windows.Forms.TextBox txtNombreyApellido;
        private System.Windows.Forms.TextBox tntCI;
        private System.Windows.Forms.TextBox tntCdC;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tntPorcentaje;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}