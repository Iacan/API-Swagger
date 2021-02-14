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
    public class showmethecode : ControllerBase
    {
        /// <summary>
        /// Obter todos os usuários.
        /// </summary>
        /// <response code="200">A lista de usuários foi obtida com sucesso.</response>
        /// <response code="500">Ocorreu um erro ao obter a lista de usuários.</response>
        [HttpGet]
        [ProducesResponseType(typeof(string), 200)]
        [ProducesResponseType(500)]
        public IActionResult Get()
        {
            var url = RetornaLinkMeuGit();
            return Ok(url);
        }

        private string RetornaLinkMeuGit()
        {
            return "Meu Link do Git";
;        }
    }
}