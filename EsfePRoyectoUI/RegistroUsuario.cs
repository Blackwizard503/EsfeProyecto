using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Xml.Linq;

namespace EsfePRoyectoUI
{
    public partial class RegistroUsuario : Form
    {
        public RegistroUsuario()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtContraseña.Clear();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
           try
            {
                TextWriter RegistrarUsuario = new StreamWriter(@"C:\Users\blackwzrd\Documents\vs code\EsfeProyecto\EsfePRoyectoUI\bin\Debug\" + txtNombre.Text + ".txt", true);
                RegistrarUsuario.WriteLine(txtContraseña.Text);
                RegistrarUsuario.Close();
                MessageBox.Show("se registro correctamente");
            }
            catch (Exception x)
            {
                MessageBox.Show("Hubo un error" + x, "error");
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FRMInicio ventanaInicio = new FRMInicio();
            ventanaInicio.Show();
        }
    }
}
