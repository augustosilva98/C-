using System;

public class Carro
{
    public string Nome { get; set; }
    public bool Novo { get; set; }
    public int AnoFabricacao { get; set; }
    public string Cor { get; set; }
    public double Potencia { get; set; }
    public int NumeroPortas { get; set; }
    public bool Flex { get; set; }

    public Carro(string nome, bool novo, int anoFabricacao, string cor, double potencia, int numeroPortas, bool flex)
    {
        Nome = nome;
        Novo = novo;
        AnoFabricacao = anoFabricacao;
        Cor = cor;
        Potencia = potencia;
        NumeroPortas = numeroPortas;
        Flex = flex;
    }
}

public class Program
{
    public static void Main()
    {
        Carro celta = new Carro("Celta", true, 2022, "Vermelho", 1.0, 4, true);
        Carro hb20 = new Carro("HB20", false, 2019, "Prata", 1.6, 4, true);
        Carro i30 = new Carro("i30", true, 2023, "Preto", 2.0, 4, false);
        Carro c3 = new Carro("C3", false, 2017, "Branco", 1.4, 4, true);
        Carro c4 = new Carro("C4", true, 2023, "Azul", 1.8, 4, true);
        Carro c4Pallas = new Carro("C4 Pallas", false, 2015, "Cinza", 2.0, 4, false);

        Carro[] carros = { celta, hb20, i30, c3, c4, c4Pallas };

        foreach (Carro carro in carros)
        {
            Console.WriteLine("Nome: " + carro.Nome);
            Console.WriteLine("Novo: " + (carro.Novo ? "Sim" : "Não"));
            if (carro.Novo)
            {
                Console.WriteLine("Potência: " + carro.Potencia);
            }
            Console.WriteLine("Cor: " + carro.Cor);
            Console.WriteLine("Número de portas: " + carro.NumeroPortas);
            Console.WriteLine("Flex: " + (carro.Flex ? "Sim" : "Não"));
            Console.WriteLine("Ano de fabricação: " + carro.AnoFabricacao);
            Console.WriteLine();
        }
    }
}
