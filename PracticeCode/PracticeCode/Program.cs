// See https://aka.ms/new-console-template for more information
int num = 5;
for(int i = 1; i <= num; i++)
{
    for (int j = 1; j <= num; j++)
    {
        if (i == j || i + j == 6)
        {
            Console.Write(j + " ");
        }
        else
        {
            Console.Write(" ");
        }
    }
    Console.WriteLine();
}