namespace CadastroAnimaisExercicio;
using CadastroAnimaisExercicio.Entidades;

//repositorio POO_CLONE Jackeline
public class Aplicacao

{
    private List<Animal> animais;

    public Aplicacao()
    {
        animais = new List<Animal>();
    }

    public void Executar()
    {
        while (true)
        {
            ExibirMenu();
            var opcao = LerInteiro("Escolha uma opção: ");

            switch (opcao)
            {
                case 1:
                    CadastrarAnimal();
                    break;
                case 2:
                    ListarAnimais();
                    break;
                case 3:
                    BuscarAnimal();
                    break;
                case 4:
                    AlterarIdade();
                    break;
                case 5:
                    FazerAnimalEmitirSom();
                    break;
                case 0:
                    Console.WriteLine("Programa encerrado.");
                    return;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            Pausar();
        }
    }

    private void ExibirMenu()
    {
        LimparConsole();
        Console.WriteLine("=== CADASTRO DE ANIMAIS ===");
        Console.WriteLine("1 - Cadastrar animal");
        Console.WriteLine("2 - Listar animais");
        Console.WriteLine("3 - Buscar animal");
        Console.WriteLine("4 - Alterar idade");
        Console.WriteLine("5 - Emitir som");
        Console.WriteLine("0 - Sair");
        Console.WriteLine();
    }

    private void CadastrarAnimal()
    {
        Console.WriteLine("\n--- Novo Animal ---");

        var nome = LerTexto("Nome: ");
        var especie = LerTexto("Espécie: ");
        var idade = LerInteiro("Idade: ");
        var nomeTutor = LerTexto("Nome do tutor: ");
        var telefone = LerTexto("Telefone do tutor: ");

        var tutor = new Tutor(nomeTutor, telefone);


        var animal = new Animal(nome, especie, idade, tutor);
        Console.WriteLine("\nAnimal cadastrado com sucesso!");
        animal.ExibirDados();
        animal.EmitirSom();
        animais.Add(animal);
    }


    private void ListarAnimais()
    {
        if (animais.Count == 0)
        {
            Console.WriteLine("\nNenhum animal cadastrado.");
            return;
        }
        else
        {
            Console.WriteLine("\n-- - Lista de Animais-- - ");
            foreach (var animal in animais)
            {
                animal.ExibirDados();
                Console.WriteLine();
            }
        }
    }
           private void BuscarAnimal()
   {
       var nome = LerTexto("Digite o nome do animal que deseja buscar: ");
       foreach (var animal in animais)
       {
           if (animal.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
           {
               Console.WriteLine("\nAnimal encontrado:");
               animal.ExibirDados();
               return;
           }
       }
       Console.WriteLine("\nAnimal não encontrado.");
   }



    
    
    private void AlterarIdade()
    {
        // TODO: implementar a opção 4.
    }

    private void FazerAnimalEmitirSom()
    {
        // TODO: implementar a opção 5.
    }

    private string LerTexto(string mensagem)
    {
        while (true)
        {
            Console.Write(mensagem);
            var texto = Console.ReadLine()?.Trim();

            if (!string.IsNullOrWhiteSpace(texto))
            {
                return texto;
            }

            Console.WriteLine("O texto não pode ficar vazio.");
        }
    }

    private int LerInteiro(string mensagem)
    {
        while (true)
        {
            Console.Write(mensagem);

            if (int.TryParse(Console.ReadLine(), out var numero))
            {
                return numero;
            }

            Console.WriteLine("Digite um número inteiro válido.");
        }
    }

    private void Pausar()
    {
        Console.WriteLine("\nPressione Enter para continuar...");
        Console.ReadLine();
    }

    private void LimparConsole()
    {
        try
        {
            Console.Clear();
        }
        catch (IOException)
        {
            // Permite executar o projeto com entrada redirecionada em testes.
        }
    }
}
