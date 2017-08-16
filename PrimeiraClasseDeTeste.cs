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
            var listaVazia = new List<int>();
            string stringVazia = "";
            string stringComEspacoEmBranco = " ";
            var strings = new List<string>();
            strings.Add(null);
            strings.Add("uma string válida");
            strings.Add("outra string válida");

            Assert.AreEqual("uma string válida", strings[1]);
            Assert.AreNotEqual("uma string válida!!!", strings[1]);
            Assert.Null(strings[0]);
            Assert.NotNull(strings[2]);
            Assert.Contains("outra string válida", strings);
            Assert.True(strings.Count == 3);
            Assert.False(strings.Count != 3);            
            Assert.IsEmpty(stringVazia);
            Assert.IsNotEmpty(stringComEspacoEmBranco);
            Assert.IsEmpty(listaVazia);
            Assert.That(() => int.Parse("dez"), Throws.TypeOf<FormatException>());
        }        
    }
}
