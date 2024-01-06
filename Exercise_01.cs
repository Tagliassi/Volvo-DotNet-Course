namespace Volvo_DotNet_Course;

class Exercise_01
{
    static void Main(string[] args)
    {
        System.Console.Write("Digite o seu nome: ");
        string nome = Console.ReadLine();

        System.Console.Write("Digite a sua altura: ");
        double altura = Convert.ToDouble(Console.ReadLine());

        System.Console.Write("Digite o seu peso: ");
        double peso = Convert.ToDouble(Console.ReadLine());

        double imc = peso/(altura*altura);

        System.Console.WriteLine($"{nome}, seu IMC é de: {imc:F2}");
    }
}
