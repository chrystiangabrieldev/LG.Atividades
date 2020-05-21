using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LG.AA.Servicos.Servicos;
using Microsoft.AspNetCore.Mvc;
using MinhasAtividades.Contratos.Controllers;

namespace LG.AA.WebApi.Controllers
{
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