using System;

namespace Volvo_DotNet_Course
{
    class MainClass
    {
        static void Main(string[] args)
        {
            // Chama o método Executar da Exercise_01
            //Exercise_01.Executar();

            //Exercise_02.Executar();

            //Exercise_03.Executar();

            //Exercise_04.Executar();

            //Exercise_05.Executar();

            Exercise_06.Executar();
        }
    }

    public class Exercise_01
    {
        public static void Executar()
        {
            System.Console.Write("Digite o seu nome: ");
            string nome = Console.ReadLine();

            System.Console.Write("Digite a sua altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            System.Console.Write("Digite o seu peso: ");
            double peso = Convert.ToDouble(Console.ReadLine());

            double imc = peso / (altura * altura);

            System.Console.WriteLine($"{nome}, seu IMC é de: {imc:F2}");
        }
    }

    public class Exercise_02
    {
        public static void Executar()
        {
            System.Console.Write("Digite o seu ano de nascimento: ");
            int ano = Convert.ToInt32(Console.ReadLine());

            int idade = (2024 - ano);

            System.Console.WriteLine($"Sua idade é {idade}");
        }
    }

    public class Exercise_03
    {
        public static void Executar()
        {
            
            double valor_locacao = 180.00;

            System.Console.Write("Digite o quantos dias quer alugar este carro: ");
            int dias = Convert.ToInt32(Console.ReadLine());

            double valor_total = (dias*valor_locacao);

            System.Console.WriteLine($"O valor a ser pago ao alugar este carro por {dias} dia(s) é: R${valor_total} reais");
        }
    }

    public class Exercise_04
    {
        public static void Executar()
        {

            System.Console.Write("Digite a temperatura em celcius: ");
            double temperatura = Convert.ToDouble(Console.ReadLine());

            double temperatura_convertida = (temperatura * 9/5) + 32;

            System.Console.WriteLine($"O valor da temperatura em Celcius para Fahrenheit é: {temperatura_convertida}");
        }
    }

    public class Exercise_05
    {
        public static void Executar()
        {

            System.Console.Write("Digite a  primeira nota: ");
            double nota_1 = Convert.ToDouble(Console.ReadLine());

            System.Console.Write("Digite a  segunda nota: ");
            double nota_2 = Convert.ToDouble(Console.ReadLine());

            System.Console.Write("Digite a  terceira nota: ");
            double nota_3 = Convert.ToDouble(Console.ReadLine());

            System.Console.Write("Digite a  quarta nota: ");
            double nota_4 = Convert.ToDouble(Console.ReadLine());

            double soma_notas = nota_1 + nota_2 + nota_3 + nota_4;

            double media_notas = soma_notas/4;

            System.Console.WriteLine($"O valor da média de notas é: {media_notas}");
        }
    }

        public class Exercise_06
    {
        public static void Executar()
        {

            System.Console.Write("Digite a  sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            int idade_meses = idade*12;

            System.Console.WriteLine($"A sua idade em meses é: {idade_meses}");
        }
    }

}
