using MinhasAtividades.Contratos.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace LG.Workflow.Servicos.Servicos
{
    public class AtividadesServico
    {
        public IEnumerable<AtividadesDto> ObtenhaTodasAsAtividades()
        {
            Random rnd = new Random();

            Thread.Sleep(rnd.Next(0, 700));

            return new List<AtividadesDto>() {
                new AtividadesDto() {
                    Id = 1,
                    Status = "0",
                    Colaborador = new ColaboradorDto()
                    {
                        Nome = "WKF - Jhon Snow",
                        Avatar = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQzlDPRr1xSW0lukY2EmVpAx5Ye1S8H5luUVOK2IqFdcsjCDQxK&s"
                    },
                    Informacoes = new List<InformacoesDto>()
                    {
                        new InformacoesDto()
                        {
                            Id = 1,
                            Label = "Ciclo",
                            Valor = "Ciclo-2019"
                        },
                        new InformacoesDto()
                        {
                            Id = 2,
                            Label = "Tipo de Processo",
                            Valor = "AutoAvaliação"
                        },
                        new InformacoesDto()
                        {
                            Id = 3,
                            Label = "Data Inicial",
                            Valor = "01/08/2019"
                        },
                        new InformacoesDto()
                        {
                            Id = 4,
                            Label = "Data Limite",
                            Valor = "30/09/2019"
                        }
                    },
                    Acoes = new List<AcoesDto> ()
                    {
                        new AcoesDto()
                        {
                            Id = 1,
                            Label = "Realizar Autoavaliação",
                        }
                    }
                },
                new AtividadesDto() {
                    Id = 2,
                    Status = "1",
                    Colaborador = new ColaboradorDto()
                    {
                        Nome = "WKF - Sansa Stark",
                        Avatar = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQzlDPRr1xSW0lukY2EmVpAx5Ye1S8H5luUVOK2IqFdcsjCDQxK&s"
                    },
                    Informacoes = new List<InformacoesDto>()
                    {
                        new InformacoesDto()
                        {
                            Id = 5,
                            Label = "Tipo de Atividade",
                            Valor = "Solicitação de Férias"
                        },
                        new InformacoesDto()
                        {
                            Id = 6,
                            Label = "Data Solicitação",
                            Valor = "11/09/2019"
                        },
                        new InformacoesDto()
                        {
                            Id = 7,
                            Label = "Início",
                            Valor = "17/02/2020"
                        },
                        new InformacoesDto()
                        {
                            Id = 8,
                            Label = "Fim",
                            Valor = "21/09/2019"
                        }
                    },
                    Acoes = new List<AcoesDto> ()
                    {
                        new AcoesDto()
                        {
                            Id = 2,
                            Label = "Executar",
                        },
                        new AcoesDto()
                        {
                            Id = 3,
                            Label = "Redirecionar",
                        },
                        new AcoesDto()
                        {
                            Id = 4,
                            Label = "Histórico",
                        }
                    }
                },
                new AtividadesDto() {
                    Id = 3,
                    Status = "2",
                    Colaborador = new ColaboradorDto()
                    {
                        Nome = "WKF - Arya Stark",
                        Avatar = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQzlDPRr1xSW0lukY2EmVpAx5Ye1S8H5luUVOK2IqFdcsjCDQxK&s"
                    },
                    Informacoes = new List<InformacoesDto>()
                    {
                        new InformacoesDto()
                        {
                            Id = 9,
                            Label = "Tipo de Movimentação",
                            Valor = "Movimentação de Pessoal Promoção"
                        },
                        new InformacoesDto()
                        {
                            Id = 10,
                            Label = "Data da Aprovação",
                            Valor = "11/09/2019"
                        },
                    },
                    Acoes = new List<AcoesDto> ()
                    {
                        new AcoesDto()
                        {
                            Id = 5,
                            Label = "Aprovar",
                        },
                        new AcoesDto()
                        {
                            Id = 6,
                            Label = "Reprovar",
                        },
                    }
                },
            };
        }
    } 
}
