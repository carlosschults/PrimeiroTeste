using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroTeste
{
    class FizzBuzz
    {
        public static string Calcular(int n)
        {
            var resposta = string.Empty;
            if (n % 3 == 0)
                resposta += "Fizz";
            if (n % 5 == 0)
                resposta += "Buzz";

            return resposta == string.Empty ? n.ToString() : resposta;
        }
    }
}
