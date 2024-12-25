namespace Rock_Paper_Scissors
{
    public class RockPaperScissorsGame
    {
        private Random _random;
        private string _opponentTurn;

        static void Main(string[] args)
        {
            RockPaperScissorsGame program = new();
            program.Game();
        }

        public RockPaperScissorsGame()
        {
            _random = new Random();
        }

        public void Game()
        {
            Console.Write("Choose [r]ock, [p]aper, [s]cissors: ");
            string playerInput = PlayerInputProcess();

            int opponentInput = OpponentInputGenerator();
            _opponentTurn = DetermineOpponentsTurn(opponentInput);

            Console.WriteLine("The computer chose: {0}", _opponentTurn);

            Console.WriteLine(DetermineTheResultOfTheGame(playerInput));
        }

        public string PlayerInputProcess()
        {
            while (true)
            {
                string playerInput = Console.ReadLine();

                if (!IsPlayerInputCorrect(playerInput))
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

        public bool IsPlayerInputCorrect(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }
            else if ((input != "r") && (input != "p") && (input != "s") && (input != "rock") && (input != "paper") && (input != "scissors"))
            {
                return false;
            }

            return true;
        }

        public string DetermineTheResultOfTheGame(string playerInput)
        {
            string res = "";

            if (playerInput == "rock" || playerInput == "r")
            {
                if (_opponentTurn == "rock")
                {
                    res = "This game was a draw!";
                }
                else if (_opponentTurn == "paper")
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
                if (_opponentTurn == "rock")
                {
                    res = "You win!";
                }
                else if (_opponentTurn == "paper")
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
                if (_opponentTurn == "rock")
                {
                    res = "You lose!";
                }
                else if (_opponentTurn == "paper")
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

        public int OpponentInputGenerator()
        {
            return _random.Next(1, 4);
        }
    }
}
