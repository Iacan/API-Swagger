using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace API2.Controllers
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
            return "https://github.com/Iacan/API-Swagger";
;        }
    }
}