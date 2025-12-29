using System;

class SnakeAndLadder
{
    // Roll the dice
    static int RollDice()
    {
        Random rnd = new Random();
        return rnd.Next(1, 7);
    }

    // Move player forward
    static int MovePlayer(int pos, int dice)
    {
        if (pos + dice > 100)
            return pos;

        return pos + dice;
    }

    // Check snake or ladder
    static int CheckBoard(int pos, int[,] board)
    {
        for (int i = 0; i < board.GetLength(0); i++)
        {
            if (board[i, 0] == pos)
                return board[i, 1];
        }
        return pos;
    }

    // Check winning condition
    static bool IsWinner(int pos)
    {
        return pos == 100;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter number of players (2 to 4):");
        int totalPlayers = int.Parse(Console.ReadLine());

        if (totalPlayers < 2 || totalPlayers > 4)
        {
            Console.WriteLine("Invalid number of players");
            return;
        }

        string[] playerNames = new string[totalPlayers];
        int[] playerPos = new int[totalPlayers];

        for (int i = 0; i < totalPlayers; i++)
        {
            Console.WriteLine("Enter player name:");
            playerNames[i] = Console.ReadLine();
            playerPos[i] = 0;
        }

        // Snakes & ladders positions
        int[,] board =
        {
            {3,22},{5,8},{11,26},{17,4},{19,38},{21,9},
            {27,56},{34,12},{40,78},{48,16},{52,67},
            {61,18},{66,89},{75,43},{88,24}
        };

        bool isGameOver = false;

        while (!isGameOver)
        {
            for (int i = 0; i < totalPlayers; i++)
            {
                Console.WriteLine("\nPress Enter to roll dice");
                Console.ReadLine();

                int dice = RollDice();
                int oldPos = playerPos[i];

                int movedPos = MovePlayer(oldPos, dice);
                int finalPos = CheckBoard(movedPos, board);

                playerPos[i] = finalPos;

                Console.WriteLine("Player : " + playerNames[i]);
                Console.WriteLine("Dice   : " + dice);
                Console.WriteLine("Move   : " + oldPos + " -> " + finalPos);

                if (movedPos != finalPos)
                {
                    if (finalPos > movedPos)
                        Console.WriteLine("Ladder");
                    else
                        Console.WriteLine("Snake");
                }

                if (IsWinner(finalPos))
                {
                    Console.WriteLine( playerNames[i]);
                    isGameOver = true;
                    break;
                }
            }
        }
    }
}
