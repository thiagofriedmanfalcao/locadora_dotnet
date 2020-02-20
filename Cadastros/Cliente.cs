using System;

namespace locadora_dotnet
{
    namespace Cadastros
    {            
        public class Cliente{
            public int idCliente;
            public string nomeCliente;
            public DateTime dtNasc;
            public string cpf; 
            public int diasDevolucao;
            public int qtdFilmesLocados;

            public Cliente(int idCliente, string nomeCliente, DateTime dtNasc, string cpf, int diasDevolucao){
                this.idCliente      = idCliente;
                this.nomeCliente    = nomeCliente;
                this.dtNasc         = dtNasc;
                this.cpf            = cpf;
                this.diasDevolucao  = diasDevolucao;
            }

            public void addFilmesLocados(int qtdFilmes){
                this.qtdFilmesLocados += qtdFilmes;
            }        

        }
    }
}