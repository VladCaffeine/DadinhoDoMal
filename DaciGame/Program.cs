using System;

public class Program 
{
    public static void Main(string[] args) 
    {
        Console.WriteLine("COMPUTADOR: Tente sua sorte LKKKKK");

        Random random = new Random();

        int PlayerOne;
        int PlayerTwo;

        int ComputadorPontos = 0;
        int JogadorPontos = 0;

        for (int i = 0; i < 10; i++) 
        {
            Console.WriteLine("Tecle uma tecla em seu teclado:\n");

            Console.ReadKey(); // waiting for a keyboard command

            PlayerOne = random.Next(1, 7);
            Console.WriteLine("VOCÊ JOGOU UM DADO: " + PlayerOne + " PONTOS" + "\n");

            PlayerTwo = random.Next(3, 7);
            Console.WriteLine("COMPUTADOR JOGO UM DADO: " + PlayerTwo + " PONTOS" + "\n");

            if (PlayerTwo > PlayerOne)
            {
                Console.WriteLine("COMPUTADOR: AUUUUUUUUUUUUUUU\n");
                Console.WriteLine("COMPUTADOR: Vamos de novo!\n");
                ComputadorPontos += 1;
            }
            else if (PlayerTwo < PlayerOne)
            {
                Console.WriteLine("COMPUTADOR: Você não tem coração?\n");
                JogadorPontos += 1;
            }
            else if (PlayerTwo == PlayerOne) 
            {
                Console.WriteLine("COMPUTADOR: Não valeu! :/ \n");
            }

            Console.WriteLine("-----------------------------------");

            System.Threading.Thread.Sleep(1000);
        }

        Console.WriteLine("PONTUAÇÃO FINAL");
        Console.WriteLine("Você fez: " + JogadorPontos + "\n" + "Computador fez: " + ComputadorPontos);
        System.Threading.Thread.Sleep(1000);
    }
}