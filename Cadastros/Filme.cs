using System;

namespace locadora_dotnet
{
    namespace Cadastros
    {        
        public class Filme{
            public int idFilme;
            public string nomeFilme;
            public DateTime dtLancamento;
            public string sinopse;
            public double valor;
            public int qtdEstoque;
            public int qtdLocacoes;

            public Filme(int idFilme, string nomeFilme, DateTime dtLancamento, string sinopse, double valor, int qtdEstoque){
                this.idFilme        = idFilme;
                this.nomeFilme      = nomeFilme;
                this.dtLancamento   = dtLancamento;
                this.sinopse        = sinopse;
                this.valor          = valor;
                this.qtdEstoque     = qtdEstoque;
            }

            public void totLocacoes(int qtd){
                this.qtdLocacoes += qtd;
            }
        }
    }
}