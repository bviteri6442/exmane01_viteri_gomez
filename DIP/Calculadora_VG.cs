using examen01_ti_gomez_viteri.OPC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// PRINCIPIO: DIP (Dependency Inversion Principle).
// - La Calculadora depende de la abstracción IOperacion_VIGO, no de implementaciones concretas.

namespace examen01_ti_gomez_viteri.DIP
{
    internal class Calculadora_VG
    {
        private readonly IOperacion_VG _operacion_VG;

        public Calculadora_VG(IOperacion_VG operacion_VG)
        {
            _operacion_VG = operacion_VG;
        }

        public string Procesar_VG(string a_VG, string b_VG)
        {
            return _operacion_VG.Calcular_VG(a_VG, b_VG);
        }

    }
}
