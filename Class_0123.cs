﻿using System;

namespace Volvo_DotNet_Course
{
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

            double imc = peso / (altura * altura); //(Math.Pow(altura,2))

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

    public class Exercise_07
    {
        public static void Executar()
        {

            System.Console.Write("Digite o seu peso: ");
            double peso = Convert.ToDouble(Console.ReadLine());

            if(peso < 50.0){
            System.Console.WriteLine($"A sua categoria de peso é: PALHA");
            }
            else if(peso < 60.0){
            System.Console.WriteLine($"A sua categoria de peso é: PLUMA");
            }
            else if(peso < 76.0){
            System.Console.WriteLine($"A sua categoria de peso é: LEVE");
            }
            else if(peso < 88){
            System.Console.WriteLine($"A sua categoria de peso é: PESADO");
            }
            else{
            System.Console.WriteLine($"A sua categoria de peso é: SUPER PESADO");
            }

        }
    }

    public class Exercise_08
    {
        public static void Executar()
        {

            System.Console.Write("Digite o primeiro número: ");
            double primeiro_numero = Convert.ToDouble(Console.ReadLine());

            System.Console.Write("Digite o segundo número: ");
            double segundo_numero = Convert.ToDouble(Console.ReadLine());

            System.Console.Write("Digite o terceiro número: ");
            double terceiro_numero = Convert.ToDouble(Console.ReadLine());

            if(terceiro_numero > primeiro_numero && terceiro_numero > segundo_numero && segundo_numero > primeiro_numero){
                System.Console.WriteLine($"A ordem é igual a: {primeiro_numero},{segundo_numero},{terceiro_numero}");
            }
            else if(terceiro_numero > primeiro_numero && terceiro_numero < segundo_numero && segundo_numero > primeiro_numero){
                System.Console.WriteLine($"A ordem é igual a: {primeiro_numero},{terceiro_numero},{segundo_numero}");
            }
            else if(terceiro_numero > primeiro_numero && terceiro_numero > segundo_numero && segundo_numero < primeiro_numero){
                System.Console.WriteLine($"A ordem é igual a: {segundo_numero},{primeiro_numero},{terceiro_numero}");
            }
            else if(terceiro_numero < primeiro_numero && terceiro_numero > segundo_numero && segundo_numero < primeiro_numero){
                System.Console.WriteLine($"A ordem é igual a: {segundo_numero},{terceiro_numero},{primeiro_numero}");
            }
            else if(terceiro_numero < primeiro_numero && terceiro_numero < segundo_numero && segundo_numero < primeiro_numero){
                System.Console.WriteLine($"A ordem é igual a: {terceiro_numero},{segundo_numero},{primeiro_numero}");
            }
            else if(terceiro_numero < primeiro_numero && terceiro_numero < segundo_numero && segundo_numero > primeiro_numero){
                System.Console.WriteLine($"A ordem é igual a: {terceiro_numero},{primeiro_numero},{segundo_numero}");
            }
        }
    }

    public class Exercise_09
    {
        public static void Executar()
        {

            System.Console.Write("Digite a hora atual: ");
            int hora = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Digite os minutos atuais: ");
            int minutos = Convert.ToInt32(Console.ReadLine());

            if(hora >= 7 && minutos >= 30 && hora <= 23){
                System.Console.Write("Aberto");
            }
            else if(hora >= 23 && minutos <= 10){
                System.Console.Write("Aberto");
            }
            else{
                System.Console.Write("Fechado");
            }
        }
    }

    public class Exercise_10
    {
        public static void Executar()
        {

            int contador = 1;
            while(contador < 100){
                if (contador % 2 == 1){
                    Console.WriteLine(contador);
                }
                contador++;
            } 
        }
    }

    public class Exercise_11
    {
        public static void Executar()
        {

            int contador = -100;

            while(contador <= 100){
                Console.WriteLine(contador);
                contador = contador + 10;
            } 
        }
    }

    public class Exercise_12
    {
        public static void Executar()
        {
            double number = 0;

            while(number < 5 || number > 10){
                System.Console.Write("Digite um número entre 5 e 10: ");
                number = Convert.ToDouble(Console.ReadLine());
            }

            System.Console.WriteLine(number);
        }
    }

    public class Exercise_13
    {
        public static void Executar()
        {
            int number = 0;
            double soma = 0;
            int cont = -1; 

            while (number != -1)
            {
                Console.Write("Digite um número: ");
                number = Convert.ToInt32(Console.ReadLine());
                soma += number;
                cont++;
            }

            soma = soma + 1;

            if (cont > 0)
            {
                Console.WriteLine(soma);
                Console.WriteLine(cont);
                Console.WriteLine(soma / cont); 
            }
            else
            {
                Console.WriteLine("Nenhum número inserido, impossível calcular a média.");
            }
        }
    }

    public class Exercise_14
    {
        public static void Executar()
        {
            System.Console.Write("Digite um número inteiro: ");
            int n_numeros = Convert.ToInt32(Console.ReadLine());
            int soma = 0;

            for(int i = 1; i <= n_numeros; i++){

                soma += i;

            }
            System.Console.WriteLine(soma);
        }
    }

    public class Exercise_15
    {
        public static void Executar()
        {
            int qtdeNumerosPares = 0;
            int qtdeNumerosImpares = 0;
            int numeroAtual = 0;

            for(int i = 0; i<10;i++){
                System.Console.Write("Digite um número inteiro: ");
                numeroAtual = Convert.ToInt32(Console.ReadLine());

                if(numeroAtual % 2 == 0){
                    qtdeNumerosPares++;
                }
                else if(numeroAtual % 2 == 1){
                    qtdeNumerosImpares++;
                }
                else{
                    System.Console.WriteLine("Valor inválido");
                }
            }
            System.Console.WriteLine($"A quantidade de números pares é igual a {qtdeNumerosPares}");
            System.Console.WriteLine($"A quantidade de números ímpares é igual a {qtdeNumerosImpares}");
        }
    }

    public class Exercise_16
    {
        public static void Executar()
        {
            
            Console.Write("Digite um número: ");
            int numeroConsole = Convert.ToInt32(Console.ReadLine());

            int resultadoTriangular = 0;
            int contador = 1;

            while (numeroConsole > resultadoTriangular)
            {
            resultadoTriangular = contador * (contador + 1) * (contador + 2);
            contador++;
            }

            if (resultadoTriangular == numeroConsole)
            {
            Console.Write("Este número é triangular!");
            }
        }
    }

    public class Exercise_17
    {
        public static void Executar()
        {
            
            int [] numerosSorteados = new int[6]; //sem repetição
            int [] numerosApostados = new int[6]; // 1 - 60 e sem repetição
            int [] numerosAcertados;

            int contador = 0;

            while (contador < 6){
                Console.Write("Digite um número para ser apostado: ");
                numerosApostados[contador] = Convert.ToInt32(Console.ReadLine());

                bool valido = true;

                /*
                if(numerosApostados >= 1 && numerosApostados <= 60){

                    foreach (int numero in numerosApostados){
                        if(numero == numerosApostados){
                            valido = false;
                        }
                    }
                }
                else{
                    valido = true;
                }
                */
                contador++;
            }

            foreach (int numero in numerosApostados){
                System.Console.WriteLine(numero);
            }

            ///----------
            Random random = new Random();

            while (numerosSorteados.Length < 6){
                int valor = random.Next(60) + 1;

                if(!numerosSorteados.Contains(valor)){
                    numerosSorteados.Append(valor);
                }
            }

            foreach (int numero in numerosSorteados){
                System.Console.WriteLine(numero);
            }
        }
    }

    public class Exercise_18
    {
        public static void Executar()
        {
            
            Pais brasil = new Pais("BRA", "Brasil", 213_993_437, 8_515_767.049);
            Pais argentina = new Pais("ARG", "Argentina", 45_376_763, 2_780_400);
            Pais paraguai = new Pais("PRY", "Paraguai", 7_292_654, 406_752);
            Pais uruguai = new Pais("URY", "Uruguai", 3_449_285, 181_034);

            
            brasil.SetPaisVizinho(argentina);
            brasil.SetPaisVizinho(paraguai);
            brasil.SetPaisVizinho(uruguai);

            argentina.SetPaisVizinho(brasil);
            paraguai.SetPaisVizinho(brasil);
            paraguai.SetPaisVizinho(argentina);
            uruguai.SetPaisVizinho(brasil);
            
            Console.WriteLine($"Código do Brasil: {brasil.codigo}");
            Console.WriteLine($"Nome do Brasil: {brasil.nome}");
            Console.WriteLine($"População do Brasil: {brasil.populacao}");
            Console.WriteLine($"Dimensão do Brasil: {brasil.dimensao}");
            Console.WriteLine();

           
            Pais outroBrasil = new Pais("BRA", "Outro Brasil", 100_000_000, 5_000_000);
            Console.WriteLine("Dois países são iguais?");
            Console.WriteLine(brasil.VerificarPaises(outroBrasil)); 
            Console.WriteLine();

            
            Console.WriteLine("Verificando se Argentina é vizinho do Brasil:");
            Console.WriteLine(brasil.VerificarPaisVizinho(argentina)); 
            Console.WriteLine();

            
            Console.WriteLine("Densidade populacional do Brasil:");
            Console.WriteLine(brasil.CalcularDensidadePopulacional());
            Console.WriteLine();

            
            Console.WriteLine("Vizinhos comuns entre Brasil e Paraguai:");
            List<Pais> vizinhosComuns = brasil.VizinhosComuns(paraguai);
            if (vizinhosComuns.Count > 0)
            {
                foreach (Pais vizinho in vizinhosComuns)
                {
                    Console.WriteLine($"{vizinho.nome}");
                }
            }
            else
            {
                Console.WriteLine("Não há vizinhos em comum entre Brasil e Paraguai.");
            }
        }
    }
}