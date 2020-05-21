using LG.Atividades.Servicos.Servicos;
using LG.MinhasAtividades.Servicos.Servicos;
using MinhasAtividades.Contratos.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LG.Atividades.Servicos.Provedores
{
    public class ProvedorDeAtividades
    {
        public async Task<List<AtividadesDto>> ObtenhaAsAtividades()
        {
            AtividadesExternas atividadesWKfServico = new AtividadesWkfServico();
            AtividadesExternas atividadesAAServico  = new AtividadesAAServico();
            AtividadesExternas atividadesSA3Servico = new AtividadesSA3Servicos();
            List<AtividadesDto> atividades = new List<AtividadesDto>();

            var atividadesWkf = await atividadesWKfServico.ObtenhaTodasAsAtividades();
            var atividadesAA  = await atividadesAAServico.ObtenhaTodasAsAtividades();
            var atividadesSA3 = await atividadesSA3Servico.ObtenhaTodasAsAtividades();

            atividades.AddRange(atividadesWkf);
            atividades.AddRange(atividadesAA);
            atividades.AddRange(atividadesSA3);

            return atividades;
        }
    }
}
