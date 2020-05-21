using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LG.Atividades.Servicos.Provedores;
using LG.MinhasAtividades.Servicos.Servicos;
using Microsoft.AspNetCore.Mvc;

namespace LG.Atividades.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AtividadesController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            try
            {
                ProvedorDeAtividades provedor = new ProvedorDeAtividades();
                var atividades = await provedor.ObtenhaAsAtividades();

                return Ok(atividades);
            }
            catch(Exception)
            {
                throw new Exception();
            }
        }
    }
}