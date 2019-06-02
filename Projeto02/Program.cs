using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02.Entities;
using Projeto02.Abstracts;
using Projeto02.Repositories;

namespace Projeto02
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                PessoaRepositoryAbstract repositoy = null;

                Console.WriteLine("Informe (1) LINK ou (2) LAMBDA");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1: repositoy = new PessoaRepositoryLINQ();
                        break;

                    case 2:
                        repositoy = new PessoaRepositoryLAMBDA();
                        break;

                    default:
                        Console.WriteLine("Verifique os valores digitados!");
                        Main(args);
                        break;
                }


                Pessoa pessoa1 = new Pessoa(1, "Julia");
                Pessoa pessoa2 = new Pessoa(2, "Ana Julia");
                Pessoa pessoa3 = new Pessoa(3, "Davi");

                repositoy.ListagemPessoas = new List<Pessoa>();
                repositoy.ListagemPessoas.Add(pessoa1);
                repositoy.ListagemPessoas.Add(pessoa2);
                repositoy.ListagemPessoas.Add(pessoa3);

                Console.WriteLine("Pessoas com nome Julia");
                foreach (var pessoa in repositoy.FiltrarPorNome("Julia"))
                {
                    Console.WriteLine("Pessoa ... " + pessoa.ToString());
                }


                if (repositoy is PessoaRepositoryLINQ) 
                {
                    Console.WriteLine("Consulta Realizado com LINK");
                }
                else if (repositoy is PessoaRepositoryLAMBDA)
                {
                    Console.WriteLine("Consulta Realizado com LAMBDA");
                }

            }
            catch (Exception e)
            {

                Console.WriteLine("Erro: "+e.Message);
            }

            Console.ReadKey();

        }
    }
}
