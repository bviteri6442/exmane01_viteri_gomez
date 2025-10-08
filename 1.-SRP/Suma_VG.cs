using System.Text;


// PRINCIPIO: SRP (Single Responsibility Principle).
// Esta clase tiene UNA sola responsabilidad: realizar la suma manual de dos strings numéricos.
// Nota: usa únicamente operaciones + y - para cumplir la restricción del examen.

namespace examen01_ti_gomez_viteri.SRP;

    internal class Suma_VG
    {
        
        public string Sumar_VG(string a_VG, string b_VG)
        {
            if (string.IsNullOrEmpty(a_VG)) a_VG = "0";
            if (string.IsNullOrEmpty(b_VG)) b_VG = "0";

            int i_VG = a_VG.Length - 1;
            int j_VG = b_VG.Length - 1;
            int carry_VG = 0;
            StringBuilder sb_VG = new StringBuilder();

            while (i_VG >= 0 || j_VG >= 0)
            {
                int da_VG = (i_VG >= 0) ? a_VG[i_VG] - '0' : 0;
                int db_VG = (j_VG >= 0) ? b_VG[j_VG] - '0' : 0;

                int s_VG = da_VG + db_VG + carry_VG;

                
                carry_VG = 0;
                while (s_VG >= 10)
                {
                    s_VG = s_VG - 10;
                    carry_VG = carry_VG + 1;
                }

                sb_VG.Insert(0, (char)('0' + s_VG));
                i_VG--;
                j_VG--;
            }

            if (carry_VG > 0)
            {
                sb_VG.Insert(0, (char)('0' + carry_VG));
            }

            
            return sb_VG.ToString();
        }

    }

