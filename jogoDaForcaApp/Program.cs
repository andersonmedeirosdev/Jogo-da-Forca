namespace jogoDaForcaApp
{
    internal class Program
    {
        static string[] palavrasArray = new string[] {"ABACATE","ABACAXI", "ACEROLA", "AÇAI", "ARAÇA", "BACABA", "BACURI", "BANANA",
            "CAJA", "CAJU", "CARAMBOLA", "CUPUAÇU", "GRAVIOLA", "GOIABA", "JABUTICABA", "JENIPAPO","MAÇA", "MANGABA",
            "MANGA", "MARACUJA", "MURICI", "PEQUI", "PITANGA", "PITAYA", "SAPOTI", "TANGERINA", "UMBU", "UVA", "UVAIA" };

        static int quantidadeErros = 0;
        static void Main(string[] args)
        {
            string palavraAleatoria = PalavraAleatoria();
            bool acertou = false, enforcou = false, letraEncontrada = false;

            char[] palavraEncontrada = new char[palavraAleatoria.Length];
            for (int i = 0; i < palavraEncontrada.Length; i++)
            {
                palavraEncontrada[i] = '_';
            }

            do
            {
                Console.Clear();


                letraEncontrada = false;

                DesenharForca();

                Console.WriteLine("Qual letra você quer chutar?");
                Console.WriteLine(palavraEncontrada);
                char letraChutada = Convert.ToChar(Console.ReadLine().ToUpper());




                for (int i = 0; i < palavraAleatoria.Length; i++)
                {
                    if (letraChutada == palavraAleatoria[i])
                    {
                        palavraEncontrada[i] = letraChutada;
                        letraEncontrada = true;
                    }
                    
                }

                if (letraEncontrada == false)
                {
                    quantidadeErros++;
                }

                if (quantidadeErros > 4)
                {
                    enforcou = true;
                    Console.WriteLine("Você perdeu...");
                }
            } while (acertou == false && enforcou == false);

            //DesenharForca();
        }

        static void DesenharForca()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("--- Tema: FRUTAS  ---");
            Console.WriteLine(" -----------         ");
            Console.WriteLine(" |         |         ");
            Console.WriteLine(" |         {0}       ", (quantidadeErros >= 1 ? "o" : " "));
            Console.WriteLine(" |       {0}{1}{2}   ", (quantidadeErros >= 3 ? "/" : " "), (quantidadeErros >= 2 ? " x " : " "), (quantidadeErros >= 3 ? "\\" : " "));

            Console.WriteLine(" |        {0}        ", (quantidadeErros >= 2 ? " x " : " "));
            Console.WriteLine(" |        {0}        ", (quantidadeErros >= 4 ? "/ \\" : " "));

            Console.WriteLine(" |                   ");
            Console.WriteLine(" |                   ");
            Console.WriteLine("|__              \t\t");
        }

        static string PalavraAleatoria()
        {
            Random sortearPalavra = new Random();
            string palavraSorteada = palavrasArray[sortearPalavra.Next(0, palavrasArray.Length)];
            return palavraSorteada;
        }


    }
}