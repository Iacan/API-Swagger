using Microsoft.AspNetCore.Mvc;
using SwaggerApiNetCore31.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace SwaggerApiNetCore31.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class taxajurosController : ControllerBase
    {
        /// <summary>
        /// Obter todos os usuários.
        /// </summary>
        /// <response code="200">Taxa de juros obtida com sucesso.</response>
        /// <response code="500">Ocorreu um erro ao obter a taxa de juros.</response>
        [HttpGet]
        [ProducesResponseType(typeof(double), 200)]
        [ProducesResponseType(500)]
        public IActionResult Get()
        {
            var juros = ObterTaxaDeJuros();
            return Ok(juros);
        }

        private double ObterTaxaDeJuros()
        {
            return 0.01;
        }
    }
}