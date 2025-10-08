using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// PRINCIPIO: SRP (Single Responsibility Principle).
// Realiza la resta manual (A - B) usando sólo operadores + y -.
// Si A < B devuelve el resultado con signo negativo.

namespace examen01_ti_gomez_viteri.SRP
{
    internal class Resta_VG
    {
        // Compara dos strings numéricos (sin signos), devuelve:
        //  1 si a > b, 0 si a == b, -1 si a < b
        private int Comparar_VG(string a_VIGO, string b_VIGO)
        {
            if (a_VIGO.Length > b_VIGO.Length) return 1;
            if (a_VIGO.Length < b_VIGO.Length) return -1;
            for (int i = 0; i < a_VIGO.Length; i++)
            {
                if (a_VIGO[i] > b_VIGO[i]) return 1;
                if (a_VIGO[i] < b_VIGO[i]) return -1;
            }
            return 0;
        }

        public string Restar_VG(string a_VIGO, string b_VIGO)
        {
            if (string.IsNullOrEmpty(a_VIGO)) a_VIGO = "0";
            if (string.IsNullOrEmpty(b_VIGO)) b_VIGO = "0";

            // Determinar signo y asegurar que trabajamos con mayor - menor
            bool negativo_VIGO = false;
            int cmp_VIGO = Comparar_VG(a_VIGO, b_VIGO);
            string mayor_VIGO = a_VIGO;
            string menor_VIGO = b_VIGO;
            if (cmp_VIGO == 0) return "0";
            if (cmp_VIGO < 0)
            {
                negativo_VIGO = true;
                mayor_VIGO = b_VIGO;
                menor_VIGO = a_VIGO;
            }

            int i_VIGO = mayor_VIGO.Length - 1;
            int j_VIGO = menor_VIGO.Length - 1;
            int borrow_VIGO = 0;
            StringBuilder sb_VIGO = new StringBuilder();

            while (i_VIGO >= 0)
            {
                int da_VG = (i_VIGO >= 0) ? mayor_VIGO[i_VIGO] - '0' : 0;
                int db_VIGO = (j_VIGO >= 0) ? menor_VIGO[j_VIGO] - '0' : 0;

                // aplicar borrow anterior sumándolo a db
                int dbTotal_VG = db_VIGO + borrow_VIGO;

                int digit_VG = 0;
                if (da_VG < dbTotal_VG)
                {
                    // tomar prestado: da += 10, borrow = 1
                    da_VG = da_VG + 10;
                    borrow_VIGO = 1;
                }
                else
                {
                    borrow_VIGO = 0;
                }

                digit_VG = da_VG - dbTotal_VG;

                sb_VIGO.Insert(0, (char)('0' + digit_VG));
                i_VIGO--;
                j_VIGO--;
            }

            // Quitar ceros a la izquierda
            string result_VG = sb_VG.ToString().TrimStart('0');
            if (string.IsNullOrEmpty(result_VG)) result_VG = "0";
            if (negativo_VIGO) result_VG = "-" + result_VG;
            return result_VG;
        }
    }
}
