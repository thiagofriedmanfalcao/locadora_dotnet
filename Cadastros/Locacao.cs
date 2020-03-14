using System;
using System.Collections.Generic;

namespace locadora_dotnet
{
    namespace Cadastros
    {    
        public class Locacao{
            public int idLocacao;
            public DateTime dtLocacao;
            public DateTime dtDevolucao;
            public Cliente objCliente;

            public Filmes_Locados objFilmesLocados;
            public int qtdFilmesPorLocacao;
            public double vlrTotalPorLocacao;


            public Locacao(int idLocacao, DateTime dtLocacao, DateTime dtDevolucao, Cliente objCliente, List<Filme> listFilmes)
            {
                this.idLocacao   = idLocacao;
                this.dtLocacao   = dtLocacao;
                this.dtDevolucao = dtDevolucao;
                this.objCliente  = objCliente;

                this.objFilmesLocados  = new Filmes_Locados(this, listFilmes);
                this.objCliente.addFilmesLocados(listFilmes.Count);
                this.AddQtdFilmesPorLocacao(listFilmes.Count);
                this.AddQtdDeLocacoes(listFilmes);

            }

            public void AddQtdFilmesPorLocacao(int qtd){
                this.qtdFilmesPorLocacao = qtd;
            }

            public void AddQtdDeLocacoes(List<Filme> listFilmes){

                foreach (Filme filme in listFilmes) {
                    filme.totLocacoes(1);
                    this.vlrTotalPorLocacao += filme.valor;
                }
            }

        }
    }
}