namespace APGuess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("--------------------");
                Console.WriteLine("Advinhe o Número");
                Console.WriteLine("--------------------\n");

                int totalTries;
                Console.WriteLine("Escolha o Nível de Dificuldade:\n1.Fácil (5 Tentativas)\n2.Médio (4 Tentativas)\n3.Difícil (3 Tentativas)\n");
                string userInput = Console.ReadLine();
                if (userInput == "1")
                {
                    totalTries = 5;
                } else if (userInput == "2")
                {
                    totalTries = 4;
                } else if (userInput == "3")
                {
                    totalTries = 3;
                } else
                {
                    Console.WriteLine("Opção Inváliada");
                    break;
                }


                    Random randGen = new Random();
                int randNumber = randGen.Next(1, 30);

                int tries;
                
                for (tries = 1; tries <= totalTries; tries++)
                {
                    Console.WriteLine($"Tentativa {tries} de {totalTries}");
                    Console.WriteLine("Digite um Número entre 1 e 30:\n");
                    int playerNumber = int.Parse(Console.ReadLine());

                    if (playerNumber == randNumber)
                    {
                        Console.WriteLine("Você acertou!");
                        break;
                    }
                    else if (playerNumber < randNumber)
                    {
                        Console.WriteLine($"O Número Sorteado é Maior que {playerNumber}");
                    }
                    else if (playerNumber > randNumber)
                    {
                        Console.WriteLine($"O Número Sorteado é Menor que {playerNumber}");
                    }

                    if (tries == totalTries)
                    {
                        Console.WriteLine($"Tentativas Esgotadas, O Número Sorteado era {randNumber}");
                    }
                }
                
               
                
                Console.WriteLine("Pressione Enter para Sair");
                string enq = Console.ReadLine().ToUpper();

                if (enq != "S")
                    break;
            }
             
        }
    }
}
