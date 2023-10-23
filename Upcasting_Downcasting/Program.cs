using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting_Downcasting
{
    internal class Program
    {  //Upcasting = Conversão para cima (FILHA X MÃE)
       //Up - para cima
       //casting - conversão
       //Resumindo: é a conversão de um objeto da classe FILHA para um objeto da classe MÃE

        //Donwcasting = Conversão para baixo (MÃE X FILHA)
        //down - para baixo
        //casting - conversão
        //Resumindo: é a conversão de um objeto da classe MÃE para um objeto da classe FILHA
        static void Main(string[] args)
        {
            //Upcasting (filho x mae)
            Funcionario meuFuncionario = new Funcionario("Joao",5000);//funcionario classe filha
            Pessoa minhaPessoa = meuFuncionario; //criando apenas uma variavel 
            //transformando um objeto da classe filha e atribuindo o valor para um VARIAVEL da classe MAE.

            minhaPessoa.ImprimeNome();

            //DOWNCASTING
            //Donwcasting
            //Não funciona!!!!!! - A gente está vindo de um contexto que tem apenas o nome para um contexto que necessida do nome e salário
            /*Pessoa minhaPessoa2 = new Pessoa("Manoel");
            Funcionario meuFuncionario2 = (Funcionario)minhaPessoa2;
            meuFuncionario2.ImprimeSalario();*/
            //O downcasting abaixo funciona, pois trata-se do retorno de um upcasting!!!!
            Funcionario meuFuncionario2 = new Funcionario("Manoel", 15000);
            Pessoa minhaPessoa2 = meuFuncionario2;
            Funcionario meuFuncionario3 = (Funcionario)minhaPessoa2;
            meuFuncionario3.ImprimeSalario();
            Console.ReadKey();

        }
    }
}
