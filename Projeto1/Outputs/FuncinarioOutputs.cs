using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto1.Entities;

namespace Projeto1.Outputs
{
    public class FuncinarioOutputs
    {

        public static void Imprimir(List<Funcionario> lista)
        {

            foreach (var funcionario in lista)
            {
                /* Console.WriteLine("Id .................." +funcionario.IdFuncionario);
                 Console.WriteLine("Nome ................" + funcionario.Nome);
                 Console.WriteLine("Salario ............." + funcionario.Salario);
                 Console.WriteLine("Admissao ............" + funcionario.DataAdmissao);
                 Console.WriteLine("Sexo ................" + funcionario.Sexo);
                 Console.WriteLine("Estado Civil ........" + funcionario.EstadoCivil);
                 Console.WriteLine("-------------------------------------------------");*/

                 Console.WriteLine(funcionario.ToString());
            }

            Console.WriteLine();
        }



    }
}
