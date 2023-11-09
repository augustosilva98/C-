using System;

class Aluno
{
    public string Nome { get; set; }
    public string Turma { get; set; }
    public string Professor { get; set; }
    public double NotaMatematica { get; set; }
    public double NotaPortugues { get; set; }
    public double NotaCiencias { get; set; }

    public string Situacao()
    {
        double media = (NotaMatematica + NotaPortugues + NotaCiencias) / 3;

        if (media >= 6)
        {
            return "Aprovado";
        }
        else if (media >= 4 && media < 6)
        {
            return "Recuperacao";
        }
        else
        {
            return "Reprovado";
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Aluno aluno = new Aluno();

        Console.WriteLine("Sistema de Gerenciamento Escolar");
        Console.WriteLine("--------------------------------");

        Console.Write("Digite o nome do aluno: ");
        aluno.Nome = Console.ReadLine();

        Console.Write("Digite a turma do aluno: ");
        aluno.Turma = Console.ReadLine();

        Console.Write("Digite o nome do professor: ");
        aluno.Professor = Console.ReadLine();

        Console.Write("Digite a nota em Matematica: ");
        aluno.NotaMatematica = double.Parse(Console.ReadLine());

        Console.Write("Digite a nota em Portugues: ");
        aluno.NotaPortugues = double.Parse(Console.ReadLine());

        Console.Write("Digite a nota em Ciencias: ");
        aluno.NotaCiencias = double.Parse(Console.ReadLine());

        Console.WriteLine("--------------------------------");
        Console.WriteLine("Resultado:");
        Console.WriteLine($"Aluno: {aluno.Nome}");
        Console.WriteLine($"Turma: {aluno.Turma}");
        Console.WriteLine($"Professor: {aluno.Professor}");
        Console.WriteLine($"Situacao: {aluno.Situacao()}");

        Console.ReadLine();
    }
}
