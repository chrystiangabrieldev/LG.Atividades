using System;
using System.Collections.Generic;
using System.Text;

namespace MinhasAtividades.Contratos.Dtos
{
    public class AtividadesDto
    {
        public int Id { get; set; }

        public string Status { get; set; }

        public ColaboradorDto Colaborador { get; set; }

        public IEnumerable<InformacoesDto> Informacoes { get; set; }

        public IEnumerable<AcoesDto> Acoes { get; set; }
    }
}
