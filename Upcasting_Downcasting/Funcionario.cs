using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting_Downcasting
{
    internal class Funcionario : Pessoa
    {

        private uint salario; //atributo
        public void ImprimeSalario()
        {
            Console.WriteLine("O Salario de "+ Nome + "é: " + salario);
        }
        //Construtor
        public Funcionario(string pNome,uint pSalario) : base (pNome)
        {
            this.salario= pSalario;
        }
    }
}
