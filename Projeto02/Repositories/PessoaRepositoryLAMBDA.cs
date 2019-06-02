using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02.Abstracts;
using Projeto02.Entities;

namespace Projeto02.Repositories
{
    public class PessoaRepositoryLAMBDA : PessoaRepositoryAbstract
    {
        public override List<Pessoa> FiltrarPorNome(string nome)
        {
            return ListagemPessoas
                .Where(p => p.Nome.Contains(nome))
                .OrderBy(p => p.IdPessoa)
                .ToList();
        }

        public override Pessoa ObterPorId(int idPessoa)
        {
            return ListagemPessoas
               .SingleOrDefault(p => p.IdPessoa == idPessoa);
               
        }
    }
}
