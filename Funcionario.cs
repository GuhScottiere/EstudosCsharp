using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tipos.Interfaces;

namespace Tipos
{
    public class Funcionario : Pessoa , IContrato 
    {
        public Funcionario(string nome, string sobreNome,int idade,double altura, int salario): base (nome, sobreNome, idade,altura)
        {
            Salario = salario;
        }

        public int Salario{get; private set;}
        
    }
}