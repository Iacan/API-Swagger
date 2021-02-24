using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Customer.Microservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculoJurosController : ControllerBase
    {
        private ILogger<CalculoJurosController> _logger;

        public CalculoJurosController(ILogger<CalculoJurosController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Efetuar calculo de juros.
        /// </summary>
        /// <response code="200">Calculo de juros obtido com sucesso.</response>
        /// <response code="500">Ocorreu um erro ao obter o calculo de juros.</response>
        [HttpGet]
        [ProducesResponseType(typeof(double), 200)]
        [ProducesResponseType(500)]
        public IActionResult Get(double valorinicial, int meses)
        {
            try
            {
                var valor = CalculaJuros(valorinicial, meses);
                return Ok(valor);
            }
            catch (Exception ex)
            {
                _logger.LogError("Erro ao tentar efetuar o calculo de Juros");
                return new StatusCodeResult(500);
            }
        }

        /// <summary>
        /// Realiza o Calculo do Juros, Dado um Valor Inicial e Temp. 
        /// </summary>
        /// <param name="valorinicial"></param>
        /// <param name="meses"></param>
        /// <returns></returns>
        private double CalculaJuros(double valorinicial, int meses)
        {
            
            double valorFinal = Math.Round(valorinicial * Math.Pow(1 + Convert.ToDouble("0.01"), meses), 2);
            return valorFinal;
        }
    }
}