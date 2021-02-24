using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ShowMeTheCode.Microservice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShowMeTheCodeController : ControllerBase
    {
        private ILogger<ShowMeTheCodeController> _logger;

        public ShowMeTheCodeController(ILogger<ShowMeTheCodeController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Obter Link do Linkedin.
        /// </summary>
        /// <response code="200">A lista de usuários foi obtida com sucesso.</response>
        /// <response code="500">Ocorreu um erro ao obter a lista de usuários.</response>
        [HttpGet]
        [ProducesResponseType(typeof(string), 200)]
        [ProducesResponseType(500)]
        public IActionResult Get()
        {
            try
            {
                var url = RetornaLinkMeuGit();
                return Ok(url);
            }
            catch (Exception ex)
            {
                _logger.LogError("Erro ao tentar retornar URL Linkedin");
                return new StatusCodeResult(500);
            }
        }

        private string RetornaLinkMeuGit()
        {
            return "https://github.com/Iacan/API-Swagger";
            ;
        }
    }
}

