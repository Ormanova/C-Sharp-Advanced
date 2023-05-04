

using System.Linq;

int[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int rows = dimensions[0];
int columns = dimensions[1];
char[,] matrix = new char[rows, columns];
//fill matrix
for (int row = 0; row < rows; row++)
{
    string input = Console.ReadLine();
    for (int col = 0; col < columns; col++)
    {
        matrix[row, col] = input[col];
    }
}
string comand = Console.ReadLine();
int currRowPlayer = 0;
int currentColPlayer = 0;
//find player position
for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < columns; col++)
    {
        if (matrix[row, col] == 'P')
        {
            currRowPlayer = row;
            currentColPlayer = col;
            matrix[currRowPlayer, currentColPlayer] = '.';
        }
    }
}

foreach (var element in comand)
{
    int oldRow = currRowPlayer;
    int oldCol = currentColPlayer;

    if (element == 'U')
    {
        currRowPlayer --;
        
    }
    else if (element == 'L')
    {
        currentColPlayer--;
    }
    else if (element == 'R')
    {
        currentColPlayer++;
    }
    else if (element == 'D')
    {
        currRowPlayer++;
    }
  

    matrix = SpreadBunnies();

    if (!(currRowPlayer >= 0 && currRowPlayer < matrix.GetLength(0) && currentColPlayer >= 0 && currentColPlayer < matrix.GetLength(1)))
    {
        PrintResult(oldRow,oldCol, "won");
        break;
    }
    if (matrix[oldRow, oldCol] == 'B')
    {
        PrintResult(currRowPlayer, currentColPlayer, "dead");
        break;
    }
}
  
char[,] SpreadBunnies()
    {
        char[,] currMatrix = new char[rows, columns];
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns; col++)
            {
                currMatrix[row, col] = matrix[row, col];
            }
        }
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns; col++)
            {
                if (matrix[row, col] == 'B')
                {
                    //up
                    if (row > 0)
                    {
                        currMatrix[row - 1, col] = 'B';
                    }
                    //right
                    if (col < matrix.GetLength(1) - 1)
                    {
                        currMatrix[row, col + 1] = 'B';
                    }
                    //down
                    if (row < matrix.GetLength(0) - 1)
                    {
                        currMatrix[row + 1, col] = 'B';
                    }
                    //left
                    if (col > 0)
                    {
                        currMatrix[row, col - 1] = 'B';
                    }
                }
            }
        }
        return matrix = currMatrix;
    }

void PrintResult( int currRowPlayer, int currentColPlayer, string result)
{
    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < columns; col++)
        {
            Console.Write(matrix[row, col]);
        }

        Console.WriteLine();
    }

    Console.WriteLine($"{result}: {currRowPlayer} {currentColPlayer}");
}