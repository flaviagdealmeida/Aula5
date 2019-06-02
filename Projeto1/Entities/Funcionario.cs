using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto1.Entities.Types;

namespace Projeto1.Entities
{
    public class Funcionario
    {
        public int IdFuncionario { get; set; }
        public string Nome { get; set; }
        public decimal Salario { get; set; }
        public DateTime DataAdmissao { get; set; }

        public Sexo Sexo { get; set; }
        public EstadoCivil EstadoCivil { get; set;}


        public Funcionario()
        {
            
        }
        //overload -> sobrescrita de metodos construtores
        public Funcionario(int idFuncionario, string nome, decimal salario, DateTime dataAdmissao, Sexo sexo, EstadoCivil estadoCivil)
        {
            IdFuncionario = idFuncionario;
            Nome = nome;
            Salario = salario;
            DataAdmissao = dataAdmissao;
            Sexo = sexo;
            EstadoCivil = estadoCivil;
        }

        //sobrescrita (override) de |To String()
        //para usar a sobrescrita de metodos das classes é necessario referenciar com o nome reservado virtual e para o metodo
        //realmente sobrescrever é necessario usar a palavra override.
        //em java super faz referencia para classe mae e em c# usa-se base

        public override string ToString()
        {
            return $"Id:{IdFuncionario}, Nome:{Nome}, Admissao:{DataAdmissao.ToString("dd/MM/yyyy")},Sexo:{Sexo}, Estado Civil: {EstadoCivil}";
        }




    }
}
