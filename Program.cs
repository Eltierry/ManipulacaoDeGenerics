// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using Exemplo_List_HashSet_SortedSet.Models;

MetodoList();
MetodoHashSet();
MetodoSortedSet();

void MetodoList()
{
    Console.WriteLine($"============ Usando LIST ===========");
    var pessoas = new List<PessoaComList>()
    {
        new PessoaComList { Nome = "Alice", Idade = 30 },
        new PessoaComList { Nome = "Bob", Idade = 25 },
        new PessoaComList { Nome = "Carol", Idade = 35 }
    };

    // Adicionando mais pessoas
    pessoas.Add(new PessoaComList { Nome = "David", Idade = 28 });
    pessoas.Add(new PessoaComList { Nome = "Eva", Idade = 22 });

    // Ordenando a lista por idade
    pessoas.Sort((p1, p2) => p1.Idade.CompareTo(p2.Idade));

    // Exibindo as pessoas ordenadas por idade
    Console.WriteLine("Pessoas ordenadas por idade:");
    foreach (var pessoa in pessoas)
    {
        Console.WriteLine(pessoa.ToString());
    }
    Console.WriteLine();
}

void MetodoHashSet()
{
    Console.WriteLine($"============ Usando HashSet ===========");
    // Criando um HashSet de pessoas
    var pessoas = new HashSet<PessoaComHashSet>()
    {
        new PessoaComHashSet { Nome = "Alice", Idade = 30 },
        new PessoaComHashSet { Nome = "Bob", Idade = 25 },
        new PessoaComHashSet { Nome = "Carol", Idade = 35 }
    };

    // Adicionando mais pessoas
    pessoas.Add(new PessoaComHashSet { Nome = "David", Idade = 28 });
    pessoas.Add(new PessoaComHashSet { Nome = "Eva", Idade = 22 });

    // Exibindo as pessoas
    Console.WriteLine("Pessoas no HashSet:");
    foreach (var pessoa in pessoas)
    {
        Console.WriteLine(pessoa.ToString());
    }
    Console.WriteLine();
}

void MetodoSortedSet()
{
    Console.WriteLine($"============ Usando SortedSet ===========");
    var pessoas = new SortedSet<PessoaComSortedSet>()
    {
        new PessoaComSortedSet { Nome = "Alice", Idade = 30 },
        new PessoaComSortedSet { Nome = "Bob", Idade = 25 },
        new PessoaComSortedSet { Nome = "Carol", Idade = 35 }
    };

    // Adicionando mais pessoas
    pessoas.Add(new PessoaComSortedSet { Nome = "David", Idade = 28 });
    pessoas.Add(new PessoaComSortedSet { Nome = "Eva", Idade = 22 });

    // Exibindo as pessoas ordenadas por idade
    Console.WriteLine("Pessoas ordenadas por idade:");
    foreach (var pessoa in pessoas)
    {
        Console.WriteLine(pessoa.ToString());
    }
    Console.WriteLine();
}
