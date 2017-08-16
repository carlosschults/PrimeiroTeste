using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroTeste
{
    class FizzBuzzTest
    {
        [Test]
        public void FizzBuzz_Passar_O_Numero_Deve_Retornar_O_Valor_Adequado()
        {   
            Assert.AreEqual("1", FizzBuzz.Calcular(1));
            Assert.AreEqual("2", FizzBuzz.Calcular(2));
            Assert.AreEqual("Fizz", FizzBuzz.Calcular(3));
            Assert.AreEqual("4", FizzBuzz.Calcular(4));
            Assert.AreEqual("Buzz", FizzBuzz.Calcular(5));
            Assert.AreEqual("Fizz", FizzBuzz.Calcular(6));
            Assert.AreEqual("Fizz", FizzBuzz.Calcular(9));
            Assert.AreEqual("Buzz", FizzBuzz.Calcular(10));
            Assert.AreEqual("Fizz", FizzBuzz.Calcular(12));
            Assert.AreEqual("FizzBuzz", FizzBuzz.Calcular(15));
        }

        [Test]
        public void FizzBuzz_Passar_Zero_Deve_Disparar_Excecao()
        {
            Assert.That(() => FizzBuzz.Calcular(0), Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void FizzBuzz_Passar_Numero_Negativo_Deve_Disparar_Excecao()
        {
            Assert.That(() => FizzBuzz.Calcular(-1), Throws.TypeOf<ArgumentOutOfRangeException>());
            Assert.That(() => FizzBuzz.Calcular(-10), Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void FizzBuzz_Passar_Numero_Maior_Que_Cem_Deve_Disparar_Excecao()
        {
            Assert.DoesNotThrow(() => FizzBuzz.Calcular(100));
            Assert.That(() => FizzBuzz.Calcular(101), Throws.TypeOf<ArgumentOutOfRangeException>());
            Assert.That(() => FizzBuzz.Calcular(105), Throws.TypeOf<ArgumentOutOfRangeException>());
        }
    }
}
