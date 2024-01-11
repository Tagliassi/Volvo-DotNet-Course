using System;
using System.IO;

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
        {
            string letraMusica = File.ReadAllText(@"in\musica.txt");
            System.Console.WriteLine(letraMusica);
        }
    }
}