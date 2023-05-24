using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Numero
    {
        public static ML.Result NumeroMayorMenor(ML.Numero numero)
        {
            ML.Result result = new ML.Result();

            numero.max = numero.NumeroU[0];
            numero.min = numero.NumeroU[0];

            for (int i = 0; i < 4; i++)
            {
                if (numero.NumeroU[i] > numero.max)
                {
                    numero.max = numero.NumeroU[i];
                }
                else if (numero.NumeroU[i] < numero.min)
                {
                    numero.min = numero.NumeroU[i];
                }
            }
            result.Correct = true;

            return result;
        }
    }
}