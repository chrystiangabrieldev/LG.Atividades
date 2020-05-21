using MinhasAtividades.Contratos.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace LG.AA.Servicos.Servicos
{
    public class AtividadesServico
    {
        public IEnumerable<AtividadesDto> ObtenhaTodasAsAtividades()
        {
            Random rnd = new Random();

            Thread.Sleep(rnd.Next(0, 700));

            return new List<AtividadesDto>() {
                new AtividadesDto() {
                    Id = 4,
                    Status = "2",
                    Colaborador = new ColaboradorDto()
                    {
                        Nome = "AA - Walter White",
                       Avatar = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQzlDPRr1xSW0lukY2EmVpAx5Ye1S8H5luUVOK2IqFdcsjCDQxK&s"
                    },
                    Informacoes = new List<InformacoesDto>()
                    {
                        new InformacoesDto()
                        {
                            Id = 11,
                            Label = "Ciclo",
                            Valor = "Ciclo-2019"
                        },
                        new InformacoesDto()
                        {
                            Id = 12,
                            Label = "Tipo de Processo",
                            Valor = "AutoAvaliação"
                        },
                        new InformacoesDto()
                        {
                            Id = 13,
                            Label = "Data Inicial",
                            Valor = "01/08/2019"
                        },
                        new InformacoesDto()
                        {
                            Id = 14,
                            Label = "Data Limite",
                            Valor = "30/09/2019"
                        }
                    },
                    Acoes = new List<AcoesDto> ()
                    {
                        new AcoesDto()
                        {
                            Id = 6,
                            Label = "Realizar Autoavaliação",
                        }
                    }
                },
                new AtividadesDto() {
                    Id = 5,
                    Status = "1",
                    Colaborador = new ColaboradorDto()
                    {
                        Nome = "AA - Jesse Pinkman",
                       Avatar = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQzlDPRr1xSW0lukY2EmVpAx5Ye1S8H5luUVOK2IqFdcsjCDQxK&s"
                    },
                    Informacoes = new List<InformacoesDto>()
                    {
                        new InformacoesDto()
                        {
                            Id = 15,
                            Label = "Tipo de Atividade",
                            Valor = "Solicitação de Férias"
                        },
                        new InformacoesDto()
                        {
                            Id = 16,
                            Label = "Data Solicitação",
                            Valor = "11/09/2019"
                        },
                        new InformacoesDto()
                        {
                            Id = 17,
                            Label = "Início",
                            Valor = "17/02/2020"
                        },
                        new InformacoesDto()
                        {
                            Id = 18,
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
                        Nome = "AA - Gus Fring",
                        Avatar = "https://avatarfiles.alphacoders.com/192/thumb-192056.jpg"
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
