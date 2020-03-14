using System;
using System.Collections.Generic;

namespace locadora_dotnet
{
    namespace Cadastros
    {        
        public class Filmes_Locados{
            Locacao objLocacao;
            List<Filme> listFilmes = new List<Filme>();

            public Filmes_Locados(Locacao objLocacao, List<Filme> listFilmes){
                this.objLocacao = objLocacao;
                this.listFilmes.AddRange(listFilmes);
            }
        }
    }
}