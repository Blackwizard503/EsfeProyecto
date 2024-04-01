using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsfePRoyectoUI
{
    public partial class FRMInicio : Form
    {
        public FRMInicio()
        {
            InitializeComponent();
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            IniciodeSesion ventanaInicioSesion = new IniciodeSesion();
            ventanaInicioSesion.Show();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistroUsuario ventanaRegistroUsuario = new RegistroUsuario();
            ventanaRegistroUsuario.Show();
        }

        private void btnInvitado_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistroVeterinaria ventanaRegistroVeterinaria = new RegistroVeterinaria();
            ventanaRegistroVeterinaria.Show();
        }
    }
}
