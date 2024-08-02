using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadoresDeAcesso
{
    public class Pessoa
    {
        private string nome;
        private int idade;

        public Pessoa()
        {
            nome = "Alisson Koerich";
            idade = 20;
        }

        public string Nome 
        {
            get { return nome; }
            set
            {
                if (nome != value)
                {
                    nome = value;
                }
                else
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
            }
        }

        public int Idade
        {
            get { return idade; }
            set
            {
                if (value > 0 && value < 140)
                {
                    idade = value;
                }
                else
                {
                    throw new ArgumentException("Idade não pode ser negativo");
                }
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            Console.WriteLine(pessoa.Nome);
            Console.WriteLine(pessoa.Idade);
            
        }
    }
}
