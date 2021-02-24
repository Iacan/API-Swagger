using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Customer.Microservice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaxaJurosController : ControllerBase
    {
        private ILogger<TaxaJurosController> _logger;

        public TaxaJurosController(ILogger<TaxaJurosController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Obter Taxa de Juros
        /// </summary>
        /// <response code="200">Taxa de juros obtida com sucesso.</response>
        /// <response code="500">Ocorreu um erro ao obter a taxa de juros.</response>
        [HttpGet]
        [ProducesResponseType(typeof(double), 200)]
        [ProducesResponseType(500)]
        public IActionResult Get()
        {
            try
            {
                var juros = ObterTaxaDeJuros();
                return Ok(juros);
            }
            catch (Exception ex)
            {
                _logger.LogError("Erro ao tentar Obter Taxa de Juros");
                return new StatusCodeResult(500);
            }
        }

        private double ObterTaxaDeJuros()
        {
            return 0.01;
        }
    }
}
