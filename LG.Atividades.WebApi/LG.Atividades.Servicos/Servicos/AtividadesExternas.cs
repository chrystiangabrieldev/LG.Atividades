using MinhasAtividades.Contratos.Dtos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LG.MinhasAtividades.Servicos.Servicos
{
    public abstract class AtividadesExternas
    {
        public HttpClient ClienteHttp { get; set; }

        public string URL { get; set; }

        public AtividadesExternas()
        {
        }

        public async Task<List<AtividadesDto>> ObtenhaTodasAsAtividades() {
            try
            {
                var ClienteHttp = new HttpClient()
                {
                    Timeout = TimeSpan.FromSeconds(5),

                };

                var response = await ClienteHttp.GetStringAsync(this.URL);
                var atividades = JsonConvert.DeserializeObject<List<AtividadesDto>>(response);

                return atividades;
            }
            catch (Exception ex)
            {
                return new List<AtividadesDto>();
            }
        }
    }
}
