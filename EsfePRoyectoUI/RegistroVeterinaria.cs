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
    public partial class RegistroVeterinaria : Form
    {
        public RegistroVeterinaria()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            txtbId.Clear();
            txtbNombre.Clear();
            dpFecha.Text = string.Empty;
        }


        private void RegistroVeterinaria_Load(object sender, EventArgs e)
        {
            //llenado de combobox
            cbRaza.DataSource = new List<string> { "Pitbull", "Pastor Aleman", "Chihuahua", };

        }


        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FRMInicio ventanaInicio = new FRMInicio();
            ventanaInicio.Show();
        }
    }
}
