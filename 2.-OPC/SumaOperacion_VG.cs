using examen01_ti_gomez_viteri.SRP;

// PRINCIPIO: OCP (implementa IOperacion_VIGO — se puede añadir sin modificar consumidores).

namespace examen01_ti_gomez_viteri.OPC;

    internal class SumaOperacion_VG : IOperacion_VG
    {

        public string Calcular_VG(string a_VG, string b_VG)
        {
            Suma_VG suma_VG = new Suma_VG(); 
            return suma_VG.Sumar_VG(a_VG, b_VG);

        }
    }

