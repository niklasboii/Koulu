Console.Write("Tehtävä 12 (N.Eloranta)");
Console.WriteLine();

Console.Write("--------------------------");
Console.WriteLine();

Console.Write("");
Console.WriteLine();

Console.Write("Anna luku, jonka neliön haluat tietää: ");
int luku = int.Parse(Console.ReadLine());


int nelio = LuvunNelio(luku); //aliohjelman kutsu

Console.WriteLine("Luvun " + luku + " nelio on " + nelio);

//Function tulos sijoitetaan kutsun perusteella int tyyppiseen muuttujaan, joten paluuarvon tyyppi on int.
int LuvunNelio(int luku) //1 function parametria tyyppiä int

{
    //Täydennetään function toteutus sellaiseksi että se kääntyy (return)
    return luku * luku; //palauttaa luvun
}