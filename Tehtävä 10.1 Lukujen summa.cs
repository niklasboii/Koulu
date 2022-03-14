Console.Write("Tehtava 10 vaihe 1");
Console.WriteLine();

Console.Write("------------------");
Console.WriteLine();

Console.Write("");
Console.WriteLine();

Console.Write("Anna kokonaislukuja, niin lasken summan reaaliajassa");
Console.WriteLine();

//esiteltiin ensin muuttujat
double summa = 0;
int luku = 0;
int raja = 100;
int i = 0;


while (summa < raja) //ehto
{
    i = i + 1; //saadaan laskemaan monsko kysyntä meneillään
    Console.Write("Anna " + i + ". luku: ");
    luku = int.Parse(Console.ReadLine());
    
   summa = summa + luku;//laskee yhten käyttäjän antamat luvut

    //Näyttää yhteenlaskettuna kuinka paljon käyttäjä on antanut
    Console.WriteLine("Summa on nyt " + summa);
}

//ilmoitus siintyy vasta kun summa ylittää rajan
Console.Write("Raja on nyt saavutettu !");
Console.WriteLine();