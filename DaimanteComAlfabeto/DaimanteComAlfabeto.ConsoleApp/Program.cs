using System;

namespace DaimanteComAlfabeto.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====================");
            Console.WriteLine("Diamante com alfabeto");
            Console.WriteLine("=====================");
            Console.WriteLine("");

            //IMPUT 
            Console.WriteLine("Insira uma das letras do alfabeto:");
            string strLetraInserida = Console.ReadLine();
            char letraAtual = Convert.ToChar(strLetraInserida);
            char letraInicial = 'A';

            int quantidadeDeEspaco = (letraAtual - letraInicial);
            int quantidadeDeEspacosInternos = 1;

            Console.WriteLine("");

            #region calculo da parte de cima
            for(int i = 65; i <= letraAtual - 1; i++)
            {
                for (int j = quantidadeDeEspaco; j > 0; j--)
                {
                    Console.Write(" ");
                }
                letraInicial = Convert.ToChar(i);
                Console.Write(letraInicial);

                if (i > 65)
                {
                    for(int x = 0; x < quantidadeDeEspacosInternos; x++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(letraInicial);
                    quantidadeDeEspacosInternos += 2;
                }

                Console.WriteLine("\n");
                quantidadeDeEspaco--;
            }
            #endregion
            #region calculo da parte de baixo
            for (int i = letraAtual; i >= 65; i--)
            {
                for (int j = quantidadeDeEspaco; j > 0; j--)
                {
                    Console.Write(" ");
                }
                letraInicial = Convert.ToChar(i);
                Console.Write(letraInicial);

                if (i > 65)
                {
                    for (int x = 0; x < quantidadeDeEspacosInternos; x++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(letraInicial);
                    quantidadeDeEspacosInternos -= 2;
                }

                Console.WriteLine("\n");
                quantidadeDeEspaco++;
            }
            #endregion
        }
    }
}
