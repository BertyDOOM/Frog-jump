using System.Threading.Channels;
bool nanovo = true;
while (nanovo)
{
    int X, Y, D;
    X = 1;
    Y = D = 0;
    while (Y < X)
    {
        Console.WriteLine("Въведете стойност на дължината на целта");
        Y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Въведете стойност на стартовата позиция (не може да е по-висока от тази на целта)");
        X = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Въведете стойност на дължината на скока");
    D = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(X + "=X " + Y + "=Y " + D + "=D");
    int XtoY = Y - X;
    Console.WriteLine(Math.Ceiling((double)XtoY / D));
    Console.WriteLine("Почни отново?y/n");
    string loop = Console.ReadLine();
    if (loop == "y")
    {
        nanovo = true;
    }
    else if (loop == "n")
    {
        nanovo = false;
    }
    else
    {
    }
}   

    










