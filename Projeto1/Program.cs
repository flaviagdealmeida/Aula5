using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto1.Entities;
using Projeto1.Entities.Types;
using Projeto1.Outputs;

namespace Projeto1
{
    class Program
    {
        static void Main(string[] args)
        {
            //substitui o nome da classe = não enfraquece a variavel, a variavel continua sendo fortemente tipada
            var lista = new List<Funcionario>();
            var func1 = new Funcionario(1,"Flavia",1000.0m,new DateTime(2019,04,01),Sexo.Feminino, EstadoCivil.Solteiro);
            //somente para variaveis locais


            var func2 = new Funcionario(2, "Davi", 1000.0m, new DateTime(2017, 04, 01), Sexo.Masculino, EstadoCivil.Casado);

            var func3 = new Funcionario(3, "Julia", 1000.0m, new DateTime(2016, 04, 01), Sexo.Feminino, EstadoCivil.Divorciado);

            lista.Add(func1);
            lista.Add(func2);
            lista.Add(func3);
                        

            FuncinarioOutputs.Imprimir(lista);


            Console.ReadKey();

        }
    }
}
