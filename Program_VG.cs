using examen01_ti_gomez_viteri.DIP;
using examen01_ti_gomez_viteri.OPC;
using System.Numerics;

namespace examen01_ti_viteri_gomez.Presentation_VG;

    class Program_VG
    {
        static void Main(string[] args)
        {
            IOperacion_VG operacion_VG = new SumaOperacion_VG(); 
            Calculadora_VG calculadora_VG = new Calculadora_VG(operacion_VG);

            Console.Write("Ingrese A: ");
            string A_VG = Console.ReadLine().Trim();

            Console.Write("Ingrese B: ");
            string B_VG = Console.ReadLine().Trim();

            string resultado_VG = calculadora_VG.Procesar_VG(A_VG, B_VG);
            
           BigInteger numA_VG = BigInteger.Parse(A_VG);
           BigInteger numB_VG = BigInteger.Parse(B_VG);

        if (numB_VG > numA_VG)
        {
            Console.WriteLine(" ");
            Console.WriteLine($"PROCESO DE LA SUMA:");
            Console.WriteLine(" ");
            Console.WriteLine(" " + numB_VG);
            Console.WriteLine("+");
            Console.WriteLine(" " + numA_VG);
        }
        else {
            Console.WriteLine(" ");
            Console.WriteLine($"PROCESO DE LA SUMA:");
            Console.WriteLine(" ");
            Console.WriteLine(" " + numA_VG);
            Console.WriteLine("+");
            Console.WriteLine(" " + numB_VG);
            
        }
                    Console.WriteLine($"RESULTADO: {resultado_VG}");
        }

    }

