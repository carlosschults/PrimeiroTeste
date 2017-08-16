using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroTeste
{
    class FizzBuzzParameterizedTest
    {
        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(3, "Fizz")]
        [TestCase(4, "4")]
        [TestCase(5, "Buzz")]
        [TestCase(6, "Fizz")]
        [TestCase(9, "Fizz")]
        [TestCase(10, "Buzz")]
        [TestCase(12, "Fizz")]
        [TestCase(15, "FizzBuzz")]
        public void FizzBuzz_Passar_O_Numero_Deve_Retornar_O_Valor_Adequado(int valor, string resultado)
        {
            Assert.AreEqual(resultado, FizzBuzz.Calcular(valor));
        }

        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(-10)]
        [TestCase(101)]
        [TestCase(110)]
        public void FizzBuzz_Passar_Numero_Fora_do_Range_Deve_Disparar_Excecao(int valor)
        {
            Assert.That(() => FizzBuzz.Calcular(valor), Throws.TypeOf<ArgumentOutOfRangeException>());
        }
    }
}
