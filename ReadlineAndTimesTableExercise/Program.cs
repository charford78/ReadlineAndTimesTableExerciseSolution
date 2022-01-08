// See https://aka.ms/new-console-template for more information
int[] factors = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12};
string input = "";

while(input != "esc")
{
    Console.WriteLine("Please enter a number.  If you wish to stop type 'esc'. ");
    Console.WriteLine();

    input = Console.ReadLine();
    Console.WriteLine();
    string comma = "";
    if(input != "esc")
    {
        foreach (int f in factors)
        {
            int num = Convert.ToInt32(input);
            Console.Write(comma + (f * num));
            comma = ", ";
        };
    }
    Console.WriteLine();
    Console.WriteLine();
}
