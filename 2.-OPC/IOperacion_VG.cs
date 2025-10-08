//PRINCIPIO OCP = Open/Closed Principle (Abierto/Cerrado)
// - Una clase debe estar abierta para extensión, pero cerrada para modificación.
// la clase SumaOperacion_VG implementa la interfaz IOperacion_VG, permitiendo añadir
// nuevas operaciones sin modificar el código existente que usa la interfaz.

namespace examen01_ti_gomez_viteri.OPC;

    public interface IOperacion_VG
    {
         string Calcular_VG(string a_VG, string b_VG);
    }

