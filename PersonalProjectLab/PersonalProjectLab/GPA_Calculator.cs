using System;
namespace PersonalProjectLab
{
    public class GPA_Calculator
    {
        public GPA_Calculator()
        {

        }

        public decimal CalculateGPA(int A_Credits, int Am_Credits, int Bp_Credits, int B_Credits, int Bm_Credits, int Cp_Credits, int C_Credits, int Cm_Credits, int Dp_Credits, int D_Credits, int F_Credits, int Total_Credits)
        {
            decimal Calculated_GPA = 0.00m;
           
            Calculated_GPA = (decimal)(A_Credits * 4 + Am_Credits * 3.7 + Bp_Credits * 3.3 + B_Credits * 3 + Bm_Credits * 2.7 + Cp_Credits * 2.3 + C_Credits * 2 + Cm_Credits * 1.7 + Dp_Credits * 1.3 + D_Credits * 1 + F_Credits * 0) / Total_Credits;

            return Calculated_GPA;
        }
    }
}
