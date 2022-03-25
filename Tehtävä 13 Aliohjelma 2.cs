Console.Write("Tehävä 13 (N.Eloranta)");
Console.WriteLine();

Console.Write("-----------------------");
Console.WriteLine();

Console.Write("");
Console.WriteLine();

Console.Write("Anna 3 lukua, niin lasken niiden summan...");
Console.WriteLine();

Console.Write("");
Console.WriteLine();

int SummanLuku(int param, int param2, int param3) //luodan aliohjelma lukujen yhteislaskuun
{
    int SummanLuku = param + param2 + param3;
    return SummanLuku;
}

//esitellään muuttujat
int luku1 = 0;
int luku2 = 0;
int luku3 = 0;

for (int i = 1; i < 4; i++)
{
    Console.Write("Anna " + i + ". luku: ");
    int luku = int.Parse(Console.ReadLine());
    if (i ==1)
    {
        luku1 = luku;
    }
    else if (i == 2)
    {
        luku2 = luku;
    }
    else
    {
        luku3 = luku;
    }
}



int Summa = SummanLuku(luku1,luku2,luku3); //aliohjelman kutsu

Console.WriteLine("Kolmen luvun " + luku1 + ", " + luku2 + " ja  " + luku3 + " summa on " + Summa);

