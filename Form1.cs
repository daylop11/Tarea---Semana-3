using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea___Semana_3
{
    public partial class frmGestionDeBiblioteca : Form
    {
        public frmGestionDeBiblioteca()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        public class VentanaPrincipal : Form
        {
            public VentanaPrincipal()
            {
                Text = "Menú Principal";
                ClientSize = new System.Drawing.Size(300, 200);

                var btnAutores = new Button
                {
                    Text = "Abrir Autores",
                    Location = new System.Drawing.Point(100, 80)
                };

                btnAutores.Click += (sender, e) => new VentanaAutores().ShowDialog();

                Controls.Add(btnAutores);
            }

            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.Run(new VentanaPrincipal());
            }
        }

        public class VentanaAutores : Form
        {
            public VentanaAutores()
            {
                Text = "Formulario de Autores";
                ClientSize = new System.Drawing.Size(250, 150);

                var lblId = new Label { Text = "ID Autor:", Location = new System.Drawing.Point(20, 20) };
                var txtId = new TextBox { Location = new System.Drawing.Point(100, 20), Width = 120 };

                var lblNombre = new Label { Text = "Nombre:", Location = new System.Drawing.Point(20, 60) };
                var txtNombre = new TextBox { Location = new System.Drawing.Point(100, 60), Width = 120 };

                var btnCerrar = new Button
                {
                    Text = "Salir",
                    Location = new System.Drawing.Point(90, 100)
                };

                btnCerrar.Click += (sender, e) => Close();

                Controls.Add(lblId);
                Controls.Add(txtId);
                Controls.Add(lblNombre);
                Controls.Add(txtNombre);
                Controls.Add(btnCerrar);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnAutores_Click(object sender, EventArgs e)
        {
            frm.Autores
        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
           
        }
    }

}
