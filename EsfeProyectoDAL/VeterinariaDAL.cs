using EsfeProyectoEN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsfeProyectoDAL
{
    public class VeterinariaDAL
    {
        private static List<VeterinariaEN> listVeterinaria = new List<VeterinariaEN>();

        public void GuardarVeterinaria (VeterinariaEN pVeterinaria)
        {
            pVeterinaria.Id = listVeterinaria.Select(listVeterinaria => listVeterinaria.Id).DefaultIfEmpty(0).Max() + 1;
            listVeterinaria.Add(pVeterinaria);
        }

    }

}
