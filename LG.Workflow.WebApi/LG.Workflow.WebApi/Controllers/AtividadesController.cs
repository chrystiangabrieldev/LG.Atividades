using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LG.Workflow.Servicos.Servicos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MinhasAtividades.Contratos.Controllers;

namespace LG.Workflow.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AtividadesController : AtividadesControllerBase
    {
        [HttpGet]
        public override IActionResult ObtenhaTodasAsAtividades()
        {
            var servico = new AtividadesServico();
            return Ok(servico.ObtenhaTodasAsAtividades());
        }
    }
}
