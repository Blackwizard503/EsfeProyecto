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
namespace EsfePRoyectoUI
{

    public partial class IniciodeSesion : Form
    {
        public IniciodeSesion()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistroVeterinaria ventanaRegistroVeterinaria = new RegistroVeterinaria();

            this.Hide();
            FRMInicio ventanaInicio = new FRMInicio();
            
            try
            {
                TextReader Inicio = new StreamReader(txtNombre.Text + ".txt");
                if (Inicio.ReadLine() == txtContraseña.Text)
                {
                    MessageBox.Show("se inicio sesion");
                    ventanaRegistroVeterinaria.Show();
                }
                else
                {
                    MessageBox.Show("no se pudo iniciar sesion");
                    ventanaInicio.Show();
                }

            }
            catch (Exception z)
            {
                MessageBox.Show("hubo un error" + z, "error");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtContraseña.Clear();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FRMInicio ventanaInicio = new FRMInicio();
            ventanaInicio.Show();
        }
    }
}