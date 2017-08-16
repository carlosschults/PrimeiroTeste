using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace PrimeiroTeste
{
    public class PrimeiraClasseDeTeste
    {
        [Test]
        public void PrimeiroMetodoDeTeste()
        {
            Assert.AreEqual(10, 5 + 5);
        }
    }
}
