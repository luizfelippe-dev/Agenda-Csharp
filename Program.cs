using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Agenda agenda = new Agenda();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n=== AGENDA DE CONTATOS ===");
            Console.WriteLine("1. Adicionar Contato");
            Console.WriteLine("2. Remover Contato");
            Console.WriteLine("3. Listar Todos os Contatos");
            Console.WriteLine("4. Buscar Contato por Nome");
            Console.WriteLine("5. Sair");
            Console.Write("Escolha uma opção: ");
            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    agenda.AdicionarContato();
                    break;
                case "2":
                    agenda.RemoverContato();
                    break;
                case "3":
                    agenda.ListarContatos();
                    break;
                case "4":
                    agenda.BuscarContato();
                    break;
                case "5":
                    running = false;
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida, tente novamente.");
                    break;
            }
        }
    }
}

class Contato
{
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }

    public override string ToString()
    {
        return $"Nome: {Nome}\nData de Nascimento: {DataNascimento.ToShortDateString()}\nTelefone: {Telefone}\nEmail: {Email}\n";
    }
}

class Agenda
{
    private List<Contato> contatos = new List<Contato>();

    public void AdicionarContato()
    {
        Contato novoContato = new Contato();

        Console.Write("Nome: ");
        novoContato.Nome = Console.ReadLine();

        Console.Write("Data de Nascimento (dd/mm/aaaa): ");
        if (DateTime.TryParse(Console.ReadLine(), out DateTime data))
        {
            novoContato.DataNascimento = data;
        }
        else
        {
            Console.WriteLine("Data inválida. Operação cancelada.");
            return;
        }

        Console.Write("Telefone: ");
        novoContato.Telefone = Console.ReadLine();

        Console.Write("Email: ");
        novoContato.Email = Console.ReadLine();

        contatos.Add(novoContato);
        Console.WriteLine("Contato adicionado com sucesso!");
    }

    public void RemoverContato()
    {
        Console.Write("Digite o nome do contato a ser removido: ");
        string nome = Console.ReadLine();

        var contato = contatos.FirstOrDefault(c => c.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
        if (contato != null)
        {
            contatos.Remove(contato);
            Console.WriteLine("Contato removido com sucesso!");
        }
        else
        {
            Console.WriteLine("Contato não encontrado.");
        }
    }

    public void ListarContatos()
    {
        if (contatos.Any())
        {
            Console.WriteLine("\n=== Lista de Contatos ===");
            foreach (var contato in contatos.OrderBy(c => c.Nome))
            {
                Console.WriteLine(contato);
            }
        }
        else
        {
            Console.WriteLine("Nenhum contato cadastrado.");
        }
    }

    public void BuscarContato()
    {
        Console.Write("Digite o nome do contato: ");
        string nome = Console.ReadLine();

        var resultado = contatos.Where(c => c.Nome.Contains(nome, StringComparison.OrdinalIgnoreCase)).ToList();

        if (resultado.Any())
        {
            Console.WriteLine("\n=== Resultados da Busca ===");
            foreach (var contato in resultado)
            {
                Console.WriteLine(contato);
            }
        }
        else
        {
            Console.WriteLine("Nenhum contato encontrado com o nome fornecido.");
        }
    }
}
