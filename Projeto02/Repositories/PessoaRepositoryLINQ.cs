using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02.Entities;
using Projeto02.Abstracts;

namespace Projeto02.Repositories
{
    public class PessoaRepositoryLINQ : PessoaRepositoryAbstract
    {
       

        public override List<Pessoa> FiltrarPorNome(string nome)
        {
            var query = from p in ListagemPessoas
                        where p.Nome.Contains(nome)
                        orderby p.IdPessoa ascending
                        select p;

            return query.ToList();

        }

        public override Pessoa ObterPorId(int idPessoa)
        {
            var query = from p in ListagemPessoas
                        where p.IdPessoa == idPessoa
                        select p;

            return query.SingleOrDefault();
        }
    }
}
