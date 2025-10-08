using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// PRINCIPIO: SRP (Single Responsibility Principle).
// Esta clase tiene UNA sola responsabilidad: realizar la suma manual de dos strings numéricos.
// Nota: usa únicamente operaciones + y - para cumplir la restricción del examen.

namespace examen01_ti_gomez_viteri.SRP
{
    internal class Suma_VG
    {
        // Sumar_VIGO: suma dos enteros grandes dados como strings (sin usar /, %, *, BigInteger, etc.)
        public string Sumar_VG(string a_VIGO, string b_VIGO)
        {
            if (string.IsNullOrEmpty(a_VIGO)) a_VIGO = "0";
            if (string.IsNullOrEmpty(b_VIGO)) b_VIGO = "0";

            int i_VIGO = a_VIGO.Length - 1;
            int j_VIGO = b_VIGO.Length - 1;
            int carry_VIGO = 0;
            StringBuilder sb_VIGO = new StringBuilder();

            while (i_VIGO >= 0 || j_VIGO >= 0)
            {
                int da_VIGO = (i_VIGO >= 0) ? a_VIGO[i_VIGO] - '0' : 0;
                int db_VIGO = (j_VIGO >= 0) ? b_VIGO[j_VIGO] - '0' : 0;

                int s_VIGO = da_VIGO + db_VIGO + carry_VIGO;

                // Calcular dígito y acarreo usando solo + y - (sin division ni modulo)
                carry_VIGO = 0;
                while (s_VIGO >= 10)
                {
                    s_VIGO = s_VIGO - 10;
                    carry_VIGO = carry_VIGO + 1;
                }

                sb_VIGO.Insert(0, (char)('0' + s_VIGO));
                i_VIGO--;
                j_VIGO--;
            }

            if (carry_VIGO > 0)
            {
                sb_VIGO.Insert(0, (char)('0' + carry_VIGO));
            }

            // remover ceros a la izquierda si fuese necesario (no ocurre para sumas estándar salvo "0")
            return sb_VIGO.ToString();
        }
        }
}
