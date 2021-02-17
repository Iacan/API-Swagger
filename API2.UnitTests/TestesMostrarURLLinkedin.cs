using Microsoft.VisualStudio.TestTools.UnitTesting;
using API2.Controllers;

namespace API2.Test
{
    [TestClass]
    public class TestesMostrarURLLinkedin
    {
        [TestMethod]
        public void TesteRetornoURLLinkedin()
        {
            showmethecode retornaLinkedin = new showmethecode();
            retornaLinkedin.Get();
        }
    }
}
