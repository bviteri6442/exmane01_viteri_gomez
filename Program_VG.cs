using examen01_ti_gomez_viteri.DIP;
using examen01_ti_gomez_viteri.OPC;

namespace examen01_ti_viteri_gomez.Presentation_VG;
    class Program_VG
    {
        static void Main(string[] args)
        {
            IOperacion_VG operacion_VG = new SumaOperacion_VG();
            Calculadora_VG calculadora_VG = new Calculadora_VG(operacion_VG);

            string A_VG = LeerNumeroValido("Ingrese A: ");
            string B_VG = LeerNumeroValido("Ingrese B: ");

            string resultado_VG = calculadora_VG.Procesar_VG(A_VG, B_VG);

            int numA_VG = A_VG.Length - 1;
            int numB_VG = B_VG.Length - 1;

            Console.WriteLine();
            Console.WriteLine("PROCESO DE LA SUMA:");
            Console.WriteLine();

            if (numB_VG > numA_VG)
            {
                Console.WriteLine(" " + B_VG);
                Console.WriteLine("+");
                Console.WriteLine(" " + A_VG);
            }
            else
            {
                Console.WriteLine(" " + A_VG);
                Console.WriteLine("+");
                Console.WriteLine(" " + B_VG);
            }

            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine($"RESULTADO: {resultado_VG}");
        }

       
        /// Método que valida 
        
        static string LeerNumeroValido(string mensaje)
        {
            while (true)
            {
                Console.Write(mensaje);
                string entrada = Console.ReadLine().Trim();

                
                if (!entrada.All(char.IsDigit))
                {
                    Console.WriteLine("Error: solo se permiten números enteros positivos.");
                    continue;
                }

                
                if (string.IsNullOrEmpty(entrada) || entrada == "0")
                {
                    Console.WriteLine("Error: debe ingresar un número mayor o igual a 1.");
                    continue;
                }

                
                if (entrada.Length > 201 || 
                    (entrada.Length == 201))
                {
                    Console.WriteLine("Error: el número no puede ser mayor que 10^200.");
                    continue;
                }

                return entrada;
            }
        }
    }

