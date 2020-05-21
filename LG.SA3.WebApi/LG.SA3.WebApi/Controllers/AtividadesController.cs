using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LG.SA3.Servicos.Servicos;
using Microsoft.AspNetCore.Mvc;
using MinhasAtividades.Contratos.Controllers;

namespace LG.SA3.WebApi.Controllers
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