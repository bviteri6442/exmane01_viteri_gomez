using examen01_ti_gomez_viteri.DIP;
using examen01_ti_gomez_viteri.OPC;

namespace examen01_ti_viteri_gomez.Presentation_VG;

    class Program_VG
    {
        static void Main(string[] args)
        {
            IOperacion_VG operacion_VIGO = new SumaOperacion_VG(); // inyectar Suma o Resta según prueba
            Calculadora_VG calculadora_VIGO = new Calculadora_VG(operacion_VIGO);

            Console.Write("Ingrese A: ");
            string A_VIGO = Console.ReadLine().Trim();

            Console.Write("Ingrese B: ");
            string B_VIGO = Console.ReadLine().Trim();

            string resultado_VIGO = calculadora_VIGO.Procesar_VG(A_VIGO, B_VIGO);
            Console.WriteLine($"RESULTADO: {resultado_VIGO}");
        }
    }

