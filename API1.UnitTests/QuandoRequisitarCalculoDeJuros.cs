using Microsoft.VisualStudio.TestTools.UnitTesting;
using API1.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace API1.Test
{
    [TestClass]
    public class QuandoRequisitarCalculoDeJuros
    {
        [TestMethod]
        public void E_Possivel_Efetuar_Calculo_De_Juros()
        {
            calculajurosController calculajuros = new calculajurosController();

            IActionResult valor = calculajuros.Get(100, 5);
            var juros = (OkObjectResult)valor;
            Assert.IsNotNull(juros.Value.ToString());
            Assert.AreEqual("105,1", juros.Value.ToString());
        }

        [TestMethod]
        public void E_Possivel_Consultar_Valor_Taxa_Juros()
        {
            taxajurosController taxajuros = new taxajurosController();

            IActionResult juros = taxajuros.Get();
            var valor = (OkObjectResult)juros;
            Assert.IsNotNull(valor.Value.ToString());
            Assert.AreEqual("0,01", valor.Value.ToString());
        }
    }
}
