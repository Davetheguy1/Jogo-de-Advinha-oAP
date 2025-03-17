using System.Diagnostics.CodeAnalysis;

namespace APGuess
{
    internal class Program
    {
        
        static void MainProgram()
        {
            Console.Clear();
            Console.WriteLine("--------------------");
            Console.WriteLine("Jogo de Advinhação");
            Console.WriteLine("--------------------\n");

            int totalTries;
            Console.WriteLine("Escolha o Nível de Dificuldade:\n\n1.Fácil (5 Tentativas)\n2.Médio (4 Tentativas)\n3.Difícil (3 Tentativas)\n---------------\n4.Sair\n");
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                Game(5);
            }
            else if (userInput == "2")
            {
                Game(4);
            }
            else if (userInput == "3")
            {
                Game(3);
            }
            else if (userInput == "4")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Opção Inváliada, Pressione Enter para retornar");
                Console.ReadLine();
                MainProgram();
            }
        }

        
        static int RandGenerator()
        {
            Random randGen = new Random();
            int randNumber = randGen.Next(1, 30);

            return randNumber;
        }
        
        
        
        
        static void Game(int maxTries)
        {
            Console.Clear();
            int totalTries = maxTries;
            int randomNumber = RandGenerator();
            int tries;
            
            for (tries = 1; tries <= totalTries; tries++)
            {
                Console.WriteLine($"Tentativa {tries} de {totalTries}");
                Console.WriteLine("Digite um Número entre 1 e 30:\n");
                int playerNumber = int.Parse(Console.ReadLine());

                if (playerNumber == randomNumber)
                {
                    Console.WriteLine("Você acertou! Deseja jogar novamente? (y/n)");
                    string playerAnswer = Console.ReadLine();
                    if (playerAnswer == "y")
                    {
                        Game(maxTries);
                    } else if (playerAnswer == "n")
                    {
                        MainProgram();
                    } else
                    {
                        Console.WriteLine("Opção Inválida");
                        playerAnswer = Console.ReadLine();
                    }
                    
                }
                else if (playerNumber < randomNumber)
                {
                    Console.WriteLine($"O Número Sorteado é Maior que {playerNumber}");
                }
                else if (playerNumber > randomNumber)
                {
                    Console.WriteLine($"O Número Sorteado é Menor que {playerNumber}");
                }

                if (tries == totalTries)
                {
                    Console.WriteLine($"Tentativas Esgotadas, O Número Sorteado era {randomNumber}");
                }
            }
        }


        static void Main(string[] args)
        {
            MainProgram();




            }
        }
    }
