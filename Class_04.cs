using System;
using System.IO;
using System.Text;

namespace Volvo_DotNet_Course
{
    public class Exercise_19
    {
        public static void Executar()
        {

        List<Pessoa> listaPessoas = new List<Pessoa>();

        }
    }

    public class Exercise_20
    {
        public static void Executar()

        {   string nomeArquivo = @"in\musica.txt";

            //string letraMusica = File.ReadAllText(nomeArquivo, Encoding.UTF8);
            string[] letraMusica = File.ReadAllLines(nomeArquivo, Encoding.UTF8);
            System.Console.WriteLine(letraMusica);

            foreach(string linha in letraMusica){
                System.Console.WriteLine(linha.ToUpper());
            }

            /*
            StreamReader stream = new StreamReader(nomeArquivo,Encoding.UTF8);
            string linha;

            while ((linha = stream.ReadLine())!= null){
                System.Console.WriteLine(linha);
            }
            stream.Close();
            */

            string novoConteudo = "novo conteúdo do arquivo";
            File.AppendAllText(nomeArquivo, novoConteudo, Encoding.UTF8);

            string[] conteudo = {"primeira","segunda", "terceira"};
            File.AppendAllLines(nomeArquivo, conteudo, Encoding.UTF8);

            File.WriteAllText(nomeArquivo, novoConteudo, Encoding.UTF8);
            File.WriteAllLines(nomeArquivo, conteudo, Encoding.UTF8);

        }
    }
}