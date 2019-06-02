using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02.Entities;

namespace Projeto02.Abstracts
{
    public abstract class PessoaRepositoryAbstract
    {
        public List<Pessoa> ListagemPessoas { get; set; }

        public abstract List<Pessoa> FiltrarPorNome(string nome);
        public abstract Pessoa ObterPorId(int idPessoa);



    }
}
