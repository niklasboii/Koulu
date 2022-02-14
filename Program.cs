﻿//Muuttujien esittely
double pituus;
//Pituuden kysely ja luku
Console.Write("Anna pituutesi senttimetreinä: ");
pituus = int.Parse(Console.ReadLine());
Console.WriteLine();

//Pituusmuunnokset
double metria = pituus / 100;
double mailia = pituus / 160934.4;
double jaardia = pituus / 91.44;
double tuumaa = pituus / 2.54;

//kahden desimaalin tarkkuudella
string metrit = string.Format("{0:0.00}", metria);
string mailit = string.Format("{0:0.00}", mailia);
string jaardit = string.Format("{0:0.00}", jaardia);
string tuumat = string.Format("{0:0.00}", tuumaa);

//tulostus näytölle
Console.WriteLine(metrit + " metriä");
Console.WriteLine(mailit + " mailia");
Console.WriteLine(jaardit + " jaardia");
Console.WriteLine(tuumat + " tuumaa");