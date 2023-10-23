using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting_Downcasting
{
    internal class Pessoa
    {
        private string nome; // atributo
        public string Nome //propriedade que ira retornar somente o nome
        {
            get { return nome; }
        }
        //METEDO
        public void ImprimeNome()
        {
            Console.WriteLine("O nome da pessoa é: " + nome);
        }
        //construtor Pessoa (obrigatorio a atribuição do pNome)
        public Pessoa (string pNome)
        {   //THIS REFERENCIA ATRIBUTO DA CLASS
            this.nome = pNome;
        }

    }
}
