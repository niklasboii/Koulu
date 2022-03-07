string [] hedelmät = { "omena", "banaani", "luumu" };

Console.Write("Tehtava 8.1");
Console.ReadLine();

Console.Write("");
Console.ReadLine();

Console.Write("------------------");
Console.ReadLine();

Console.Write("");
Console.ReadLine();

Console.Write("Montako hedelmää haluat nähdä: ");
int luku = int.Parse(Console.ReadLine());

for (int i = 0; i < luku; i++)
{
    Console.WriteLine(hedelmät[i]);
}

