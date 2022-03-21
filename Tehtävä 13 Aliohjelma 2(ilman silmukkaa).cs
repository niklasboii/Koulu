Console.Write("Tehävä 13 (N.Eloranta)");
Console.WriteLine();

Console.Write("-----------------------");
Console.WriteLine();

Console.Write("");
Console.WriteLine();

Console.Write("Anna 3 lukua, niin lasken niiden summan...");
Console.WriteLine();

int SummanLuku(int luku1, int luku2, int luku3) //luodan aliohjelma lukujen yhteislaskuun
{

    return luku1 + luku2 + luku3;
}

//esitellään muuttujat
int luku1 = 0;
int luku2 = 0;
int luku3 = 0;



    Console.Write("Anna 1. luku: ");
    luku1 = int.Parse(Console.ReadLine());

    Console.Write("Anna 2. luku: ");
    luku2 = int.Parse(Console.ReadLine());

    Console.Write("Anna 3. luku: ");
    luku3 = int.Parse(Console.ReadLine());

int Summa = SummanLuku(luku1,luku2,luku3); //aliohjelman kutsu

Console.WriteLine("Kolmen luvun " + luku1 + ", " + luku2 + " ja  " + luku3 + " summa on " + Summa);

