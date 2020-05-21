using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MinhasAtividades.Contratos.Controllers {

    [ApiController]
    [Route("[controller]")]
    public abstract class AtividadesControllerBase : ControllerBase
    {
        [HttpGet]
        public abstract IActionResult ObtenhaTodasAsAtividades();
    } 
}