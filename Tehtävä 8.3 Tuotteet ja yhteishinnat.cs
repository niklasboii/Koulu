
Console.Write("Tehtävä 8.3");
Console.WriteLine();

Console.Write("");
Console.WriteLine();

Console.Write("----------------");
Console.WriteLine();

Console.Write("");
Console.WriteLine();

Console.Write("Kuinka monta tuotetta lisätään: ");
int maara = int.Parse(Console.ReadLine());
//kysytään kuinka monta kertaa kysytään nimi, hinta ja lukumäärä

String[] nimi = new string [maara];

double[] hinta = new double [maara];

int[] lukumaara = new int [maara];

int T; // T antaa käyttäjälle järjestysmumeron joka on yhtä isompi kuin taulukossa käyetettävä numero
//kysytään tuotteiden nimi, hinta ja lukumäärä

for (int i = 0; i < maara; i++)
{
    T = i + 1;
    Console.Write ("Anna " + T + ". tuotteen nimi: " );
    nimi[i] = Console.ReadLine();
    Console.Write("Anna " + T + ". tuotteen hinta: ");
    hinta[i] = double.Parse(Console.ReadLine());
    Console.Write("Anna " + T + ". tuotteen lukumäärä: ");
    lukumaara[i] = int.Parse(Console.ReadLine());

}

Console.Write("");
Console.WriteLine();

for (int i = 0; i < maara; i++) //Tulostetaan tiedot
{
    Console.WriteLine( nimi[i] + " " + hinta[i] * lukumaara[i] + " euroa");
    //Lukumäärä * Hinta
    
}
Console.ReadKey(true);
