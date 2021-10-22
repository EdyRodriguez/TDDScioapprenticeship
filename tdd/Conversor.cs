using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd
{
   public class Conversor
    {
        public string Converter(int binicial, int bfinal, string valor)
        {
            string resultado = "";
            int value = 0;
            switch (bfinal)
            {
                case 10:
                    long result = Convert.ToInt64(valor, binicial);
                    return result.ToString();
                case 16:
                    if(binicial == 2)
                    {
                         resultado = Convert.ToString(anytoDec(binicial, valor), bfinal);
                        return resultado;

                    }
                    else
                    {

                        value = Int32.Parse(valor);
                        resultado = Convert.ToString(value, bfinal);
                        return resultado;
                    }

                    
                    
                case 2:

                    if (binicial == 16)
                    {
                        resultado = Convert.ToString(anytoDec(binicial, valor), bfinal);
                        return resultado;

                    }
                    else
                    {
                        value = Int32.Parse(valor);
                        resultado = Convert.ToString(value, bfinal);
                        return resultado;
                    }
                default:
                    Console.WriteLine("Escribe una base valida");
                    return "0";
                   
            }
            
        }

        private long anytoDec(int binicial, string valor)
        {
            return Convert.ToInt64(valor, binicial);
        }

    }
}
