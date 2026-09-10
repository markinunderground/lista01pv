using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroAnimaisExercicio.Entidades
{
    public class Tutor
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }

        public Tutor (string nome, string telefone)
        {
            Nome = nome;
            Telefone = telefone;
        }

        public void ExibirDados()
        {
            Console.WriteLine("Tutor: " + Nome);
            Console.WriteLine("Telefone: " + Telefone);
        }
    }
}
