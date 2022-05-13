

int[] board = new int[9];
board[0] = 1; 
board[1] = 2; 
board[2] = 0;
board[3] = 0;
board[4] = 0;
board[5] = 0;
board[6] = 0;
board[7] = 0;
board[8] = 0;

for(int i = 0; i < 9; i++)
{
    //Console.WriteLine("Lauks " + i + " satur " + board[i]);
    //Print o or x in each square, where X is player1, O player2;
    if (board[i] == 0)
    { 
    Console.WriteLine("*");
    }
    if (board[i] == 1)
    {
        Console.WriteLine("X");
    }

    if (board[i] == 2)
    {
        Console.WriteLine("O");
    }

    //Insert new line at end of second char;
    if (i == 2 || i == 5 || i == 8)
    {
        Console.WriteLine();
    }
}