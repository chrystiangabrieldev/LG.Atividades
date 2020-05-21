using LG.MinhasAtividades.Servicos.Servicos;
using System;
using System.Collections.Generic;
using System.Text;

namespace LG.Atividades.Servicos.Servicos
{
    public class AtividadesAAServico : AtividadesExternas
    {
        public AtividadesAAServico()
        {
            this.URL = "https://localhost:44301/Atividades";
        }
    }
}
