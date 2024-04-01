using EsfeProyectoDAL;
using EsfeProyectoEN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsfeProyectoBL
{
    public class VeterinariaBL
    {

        private VeterinariaDAL VeterinariaDAL = new VeterinariaDAL();
        public void GuardarVeterinaria(VeterinariaEN pVeterinaria)
        {
            VeterinariaDAL.GuardarVeterinaria(pVeterinaria);//se utilizo el objeto creado en la instancia
        }

    }
}
