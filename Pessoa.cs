using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Volvo_DotNet_Course
{
    public class Pessoa
    {
        public string nome{get;set;}
        public string cpf{get;set;}
        public int idade{get;set;}
        List<Pessoa> listaPessoas = new List<Pessoa>();
        public Pessoa(string nome, string cpf, int idade)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.idade = idade;
        }
        
        void cadastrarPessoa(){
                try{
                    Console.Write("Digite o nome da pessoa: ");
                    string nome = Console.ReadLine();

                    Console.Write("Digite o cpf da pessoa: ");
                    string cpf = Console.ReadLine();

                    Console.Write("Digite a idade da pessoa: ");
                    int idade = Convert.ToInt32(Console.ReadLine());

                    Pessoa p1 = new Pessoa(nome, cpf, idade);

                }catch(Exception e){
                    throw new PessoaException("Dados inválidos");
                }
        }
        void deletarPessoa(string cpf){

            try{
                foreach(Pessoa pessoa in listaPessoas){
                    if(pessoa.cpf == cpf){
                        listaPessoas.Remove(pessoa);
                    }
                }
            }catch(Exception e){
                throw new PessoaException("Pessoa não existe na lista");
            }

        }
        List<Pessoa> imprimirPessoas(){
            return listaPessoas;
        }
    }
    class PessoaException : ApplicationException{
        public string sugestaoCorrecao {get;set;}

        public PessoaException(string sugestao){
            this.sugestaoCorrecao = sugestao;
        }
    }
}