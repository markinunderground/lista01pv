using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroAnimaisExercicio.Entidades
{
    public class Animal
    {
        public string Nome;
        public string Especie;
        public int Idade;

        public Tutor Tutor { get; private set; }

        public Animal(string nome, string especie,  int idade, Tutor tutor)
        {
            Nome = nome;
            Especie = especie;
            Idade = idade;
            Tutor = tutor;
        }

        public void ExibirDados()
        {
            Console.WriteLine(Nome + " - " + Especie + " - " + Idade + " anos");    
        
        }

        public void EmitirSom()
        {
            Console.WriteLine($"{Nome} esta emitindo um som caracteristico da espécie {Especie}. ");
        }

        public void AlterarIdade(int novaIdade)
        {
            if (novaIdade >= 0)
            {
                Idade = novaIdade;
                Console.WriteLine($"A idade do animal {Nome} foi alterada para {Idade} anos.");
            }
            else
            {
                Console.WriteLine("A idade não pode ser negativa.");
            }
        }
    }
}

