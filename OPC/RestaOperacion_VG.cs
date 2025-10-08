using examen01_ti_gomez_viteri.SRP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// PRINCIPIO: OCP (puedes agregar la operación sin cambiar clientes).

namespace examen01_ti_gomez_viteri.OPC
{
    internal class RestaOperacion_VG : IOperacion_VG
    {
        public string Calcular_VG(string a_VG, string b_VG)
        {
            Resta_VG resta_VG = new Resta_VG();
            return resta_VG.Restar_VG(a_VG, b_VG);
        }
    }
}
