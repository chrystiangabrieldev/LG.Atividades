using MinhasAtividades.Contratos.Dtos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LG.MinhasAtividades.Servicos.Servicos
{
    public class AtividadesWkfServico : AtividadesExternas
    {
        public AtividadesWkfServico()
        {
            this.URL = "https://localhost:44302/Atividades";
        }
    }
}
