

Console.Write("Tehtävä 8.2");
Console.WriteLine();

Console.Write("");
Console.WriteLine();

Console.Write("----------------");
Console.WriteLine();

Console.Write("");
Console.WriteLine();


Console.OutputEncoding = System.Text.Encoding.UTF8; // jotta tunnistii € merkin muuten ilman hettää ? merkin

String[] tuotteet = { "Vasara", "Saha", "Kirves" }; 

int[] hinnat = {5,10,15};


for (int i = 0; i < 3; i++)
{
    Console.WriteLine(tuotteet[i] + " " + hinnat[i] + " €"); // tuotteet - väli -tuotteiden hinnat - väli sekä € merkki
}