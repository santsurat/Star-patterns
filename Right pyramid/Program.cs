// See https://aka.ms/new-console-template for more information


//  right half Pyramid
int n = 4;

for (int r = 0; r < n; r++)
{
    for (int c = 0; c < n - r; c++)
    {
        Console.Write(" ");
    }
    for (int j = 0; j < r + 1; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

