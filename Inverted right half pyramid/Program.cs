// See https://aka.ms/new-console-template for more information


// inverted right half pyramid

int n = 4;

for (int r = 0; r < n; r++)
{
    for (int c = 0; c < r + 1; c++)
    {
        Console.Write(" ");
    }
    for (int j = 0; j < n - r; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}


