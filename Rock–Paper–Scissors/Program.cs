namespace Rock_Paper_Scissors
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new();
            program.Game();
        }

        public void Game()
        {
            Console.Write("Choose [r]ock, [p]aper, [s]cissors: ");
            string playerInput = playerInputProcess();

            Random random = new();

            int opponentInput = OpponentInputGenerator(random);
            string opponentTurn = DetermineOpponentsTurn(opponentInput);

            Console.WriteLine("The computer chose: {0}", opponentTurn);

            Console.WriteLine(DetermineTheResultOfTheGame(playerInput, opponentTurn));
        }

        public string playerInputProcess()
        {
            while (true)
            {
                string playerInput = Console.ReadLine();

                if (!isPlayerInputCorrect(playerInput))
                {
                    Console.Write("Wrong input! Try again: "); continue;
                }
                else
                {
                    return playerInput;
                }
                
            }
        }

        public string DetermineOpponentsTurn(int opponentInput)
        {
            string res = "";

            switch (opponentInput)
            {
                case 1:
                    res = "rock"; break;
                case 2:
                    res = "paper"; break;
                case 3:
                    res = "scissors"; break;
            }

            return res;
        }

        public bool isPlayerInputCorrect(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }    
            else if ( (input != "r") && (input != "p") && (input != "s") && (input != "rock") && (input != "paper") && (input != "scissors"))
            {
                return false;
            }

            return true;
        }

        public string DetermineTheResultOfTheGame(string playerInput, string opponentTurn)
        {
            string res = "";

            if (playerInput == "rock" || playerInput == "r")
            {
                if (opponentTurn == "rock")
                {
                    res = "This game was a draw!";
                }
                else if (opponentTurn == "paper")
                {
                    res = "You lose!";
                }
                else
                {
                    res = "You win!";
                }
            }
            else if (playerInput == "paper" || playerInput == "p")
            {
                if (opponentTurn == "rock")
                {
                    res = "You win!";
                }
                else if (opponentTurn == "paper")
                {
                    res = "This game was a draw!";
                }
                else
                {
                    res = "You lose!";
                }
            }
            else
            {
                if (opponentTurn == "rock")
                {
                    res = "You lose!";
                }
                else if (opponentTurn == "paper")
                {
                    res = "You won!";
                }
                else
                {
                    res = "This game was a draw!";
                }
            }

            return res;
        }

        public int OpponentInputGenerator(Random random)
        {
            return random.Next(1, 4);
        }
    }
}
