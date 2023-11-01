using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace Tipos
{
    public abstract  class Pessoa
    {
        public Pessoa(string nome, string sobreNome, int idade, double altura)
        {
            Nome = nome;
            SobreNome = sobreNome;
            Idade = idade;
            Altura = altura;
        }

        public string Nome {get; private set;}
        public string SobreNome {get; private set;}

        public int Idade {get; private set;}

        public double Altura {get; private set;}

        public string Andar()
        {
             return $"{this.Nome} esta andando";
        }
    }
}