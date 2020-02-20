using System;
using System.Collections.Generic;

namespace locadora_dotnet
{
    namespace Cadastros
    {                
        class Locadora
        {
            static void Main(string[] args)
            {
                Cliente Cliente1 = new Cliente(1, "Thiago", new Locadora().FormataData("1994-06-10"), "094.602.329-81", 5);
                Cliente Cliente2 = new Cliente(2, "Mateus", new Locadora().FormataData("2003-02-23"), "981.998.100-09", 10);
                Cliente Cliente3 = new Cliente(3, "Jackson", new Locadora().FormataData("1998-05-15"), "521.671.710-21", 15);
                Cliente Cliente4 = new Cliente(4, "Carlos", new Locadora().FormataData("2009-09-06"), "672.506.850-23", 20);
                Cliente Cliente5 = new Cliente(5, "João", new Locadora().FormataData("1988-07-19"), "865.518.360-11", 25);              

                Filme Filme1  = new Filme(1, "O Homem das Cavernas", new Locadora().FormataData("2006-06-11"), "Ação", 10.0, 20);
                Filme Filme2  = new Filme(2, "A Guerra do Fogo", new Locadora().FormataData("2003-01-05"), "Aventura", 15.20, 20);
                Filme Filme3  = new Filme(3, "A Era do Gelo", new Locadora().FormataData("2003-03-13"), "Comédia", 22.50, 20);
                Filme Filme4  = new Filme(4, "Fantasia", new Locadora().FormataData("2006-06-15"), "Docuficção", 33.10, 20);
                Filme Filme5  = new Filme(5, "O Poderoso Chefão", new Locadora().FormataData("2012-02-09"), "Espionagem", 12.0, 20);
                Filme Filme6  = new Filme(6, "Cidadão Kane", new Locadora().FormataData("2011-06-10"), "Documentário", 9.30, 20);
                Filme Filme7  = new Filme(7, "Casablanca", new Locadora().FormataData("2006-10-25"), "Aventura", 2.50, 20);
                Filme Filme8  = new Filme(8, "Tubarão", new Locadora().FormataData("1994-06-10"), "Musical", 11.5, 20);
                Filme Filme9  = new Filme(9, "Star Wars", new Locadora().FormataData("2011-11-23"), "Aventura", 27.8, 20);
                Filme Filme10 = new Filme(10, "Fargo", new Locadora().FormataData("2011-12-27"), "Musical", 19.23, 20);

                DateTime dataAtual = DateTime.Now;

                List<Filme> filmesLocados = new List<Filme>();
                filmesLocados.Add(Filme1);
                filmesLocados.Add(Filme10);
                Locacao Locacao1 = new Locacao(1, dataAtual, new Locadora().CalculaDtDevolucao(Cliente1.diasDevolucao), Cliente1, filmesLocados);

                filmesLocados = new List<Filme>();
                filmesLocados.Add(Filme3);
                filmesLocados.Add(Filme8);
                Locacao Locacao2 = new Locacao(1, dataAtual, new Locadora().CalculaDtDevolucao(Cliente1.diasDevolucao), Cliente1, filmesLocados);

                filmesLocados = new List<Filme>();
                filmesLocados.Add(Filme5);
                filmesLocados.Add(Filme4);
                filmesLocados.Add(Filme3);
                Locacao Locacao3 = new Locacao(1, dataAtual, new Locadora().CalculaDtDevolucao(Cliente3.diasDevolucao), Cliente3, filmesLocados);

                filmesLocados = new List<Filme>();
                filmesLocados.Add(Filme5);
                filmesLocados.Add(Filme10);
                filmesLocados.Add(Filme1);
                filmesLocados.Add(Filme8);
                filmesLocados.Add(Filme3);
                Locacao Locacao4 = new Locacao(1, dataAtual, new Locadora().CalculaDtDevolucao(Cliente5.diasDevolucao), Cliente5, filmesLocados);

                filmesLocados = new List<Filme>();
                filmesLocados.Add(Filme7);
                filmesLocados.Add(Filme9);
                Locacao Locacao5 = new Locacao(1, dataAtual, new Locadora().CalculaDtDevolucao(Cliente5.diasDevolucao), Cliente5, filmesLocados);

                Console.WriteLine("***Quantidade de Filmes locados por cada cliente***");
                Console.WriteLine("Cliente: " + Cliente1.nomeCliente + " alugou " + Cliente1.qtdFilmesLocados + " filmes");
                Console.WriteLine("Cliente: " + Cliente2.nomeCliente + " alugou " + Cliente2.qtdFilmesLocados + " filmes");
                Console.WriteLine("Cliente: " + Cliente3.nomeCliente + " alugou " + Cliente3.qtdFilmesLocados + " filmes");
                Console.WriteLine("Cliente: " + Cliente4.nomeCliente + " alugou " + Cliente4.qtdFilmesLocados + " filmes");
                Console.WriteLine("Cliente: " + Cliente5.nomeCliente + " alugou " + Cliente5.qtdFilmesLocados + " filmes");           
                
                Console.WriteLine("***Quantidade de Filmes por Locação***");        
                Console.WriteLine("Locação 1: " + Locacao1.qtdFilmesPorLocacao + " filmes");        
                Console.WriteLine("Locação 2: " + Locacao2.qtdFilmesPorLocacao + " filmes");        
                Console.WriteLine("Locação 3: " + Locacao3.qtdFilmesPorLocacao + " filmes");        
                Console.WriteLine("Locação 4: " + Locacao4.qtdFilmesPorLocacao + " filmes");        
                Console.WriteLine("Locação 5: " + Locacao5.qtdFilmesPorLocacao + " filmes");        

                Console.WriteLine("***Valor Total por Locação***");        
                Console.WriteLine("Locação 1: " + Locacao1.vlrTotalPorLocacao + " filmes");        
                Console.WriteLine("Locação 2: " + Locacao2.vlrTotalPorLocacao + " filmes");        
                Console.WriteLine("Locação 3: " + Locacao3.vlrTotalPorLocacao + " filmes");        
                Console.WriteLine("Locação 4: " + Locacao4.vlrTotalPorLocacao + " filmes");        
                Console.WriteLine("Locação 5: " + Locacao5.vlrTotalPorLocacao + " filmes");        

                Console.WriteLine("***Quantidade de Locações por Filme***");        
                Console.WriteLine("Filme " + Filme1.nomeFilme + " foi locado " + Filme1.qtdLocacoes);
                Console.WriteLine("Filme " + Filme2.nomeFilme + " foi locado " + Filme2.qtdLocacoes);
                Console.WriteLine("Filme " + Filme3.nomeFilme + " foi locado " + Filme3.qtdLocacoes);
                Console.WriteLine("Filme " + Filme4.nomeFilme + " foi locado " + Filme4.qtdLocacoes);
                Console.WriteLine("Filme " + Filme5.nomeFilme + " foi locado " + Filme5.qtdLocacoes);
                Console.WriteLine("Filme " + Filme6.nomeFilme + " foi locado " + Filme6.qtdLocacoes);
                Console.WriteLine("Filme " + Filme7.nomeFilme + " foi locado " + Filme7.qtdLocacoes);
                Console.WriteLine("Filme " + Filme8.nomeFilme + " foi locado " + Filme8.qtdLocacoes);
                Console.WriteLine("Filme " + Filme9.nomeFilme + " foi locado " + Filme9.qtdLocacoes);
                Console.WriteLine("Filme " + Filme10.nomeFilme + " foi locado " + Filme10.qtdLocacoes);

            }

            public DateTime CalculaDtDevolucao(int devDias){
                DateTime dtDevolucao = DateTime.Now;
                dtDevolucao.Subtract(TimeSpan.FromDays(devDias));
                return dtDevolucao;
            }

            public DateTime FormataData(String dateString)
            {
                DateTime data = new DateTime();
                try
                {
                    data = DateTime.Parse(dateString);
                }
                catch (System.Exception)
                {
                    Console.WriteLine("DATA INFORMADA NO FORMATO INCORRETO!");
                    throw;
                }

                return data;
            }


        }
    }
}
