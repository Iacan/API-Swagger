using Microsoft.VisualStudio.TestTools.UnitTesting;
using API1.Controllers;

namespace API1.Test
{
    [TestClass]
    public class TestesCalculoDeJuros
    {
        [TestMethod]
        public void TesteRetornaCalculoJuros()
        {
            calculajurosController calculajuros = new calculajurosController();
            calculajuros.Get(100, 50);
        }

        [TestMethod]
        public void TesteRetornaTaxaJuros()
        {
            taxajurosController taxajuros = new taxajurosController();
            taxajuros.Get();
        }
    }
}
