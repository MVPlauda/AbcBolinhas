internal class Program
{
    private static void Main(string[] args)
    {
        string nome;
        double salarioAtual, novoSalario;

        Console.Write("Digite o nome do funcionário: ");
        nome = (Console.ReadLine());
        Console.Write("Digite o salário atual do funcionário: ");
        salarioAtual = double.Parse(Console.ReadLine());

        // calcula o novo salário com aumento de 25%
        novoSalario = salarioAtual * 1.25;

        // exibe o nome do funcionário e o novo salário
        Console.WriteLine($"O novo salário de {nome} é: {novoSalario}");
    }
}
