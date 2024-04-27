using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExplorandoClasses.Models
{
    public class Pessoa
    {
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        private string _nome;
        private string _sobrenome;
        private int _idade;

        public string Nome 
        { 
            get => _nome.ToUpper();
            
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio.");
                }
                _nome = value;
            } 
        }
        public string Sobrenome 
        { 
            get => _sobrenome.ToUpper(); 
            
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O sobrenome não pode estar vazio.");
                }
                _sobrenome = value;
            } 
        }
        public string NomeCompleto 
        {
            get => $"{_nome} {_sobrenome}";
        }
        public int Idade 
        {
            get => _idade;
            set
            {
                if(value == 0)
                {
                    throw new ArgumentException("A idade não pode ser igual a zero.");
                }
                _idade = value;
            }
        }
        public void Apresentar()
        {
            Console.WriteLine($"Meu nome é {NomeCompleto} tenho {_idade} anos.");
        }
    }
}