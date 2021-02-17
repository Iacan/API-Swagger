using Microsoft.VisualStudio.TestTools.UnitTesting;
using API1.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace API1.Test
{
    [TestClass]
    public class TestesCalculoDeJuros
    {
        [TestMethod]
        public void TesteRetornaCalculoJuros()
        {
            calculajurosController calculajuros = new calculajurosController();

            IActionResult valor = calculajuros.Get(100, 5);
            var juros = (OkObjectResult)valor;
            Assert.AreEqual("105,1", juros.Value.ToString());
        }

        [TestMethod]
        public void TesteRetornaTaxaJuros()
        {
            taxajurosController taxajuros = new taxajurosController();

            IActionResult juros = taxajuros.Get();
            var valor = (OkObjectResult)juros;
            Assert.AreEqual("0,01", valor.Value.ToString());
        }
    }
}
