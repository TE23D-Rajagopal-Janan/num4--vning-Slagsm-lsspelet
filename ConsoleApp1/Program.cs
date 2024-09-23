using System.Runtime.Serialization;

int hp1 = 100;
int hp2 = 100;

Console.WriteLine("Vad heter spelare 1");
string name1 = Console.ReadLine();
while (name1 == "") 
{
    Console.WriteLine("Skriv in ditt namn/Write your name");
    name1 = Console.ReadLine();
}  
Console.WriteLine("Vad heter spelare 2");
string name2 = Console.ReadLine();
while (name2 == "") 
{
    Console.WriteLine("Skriv in ditt namn/Write your name");
    name2 = Console.ReadLine();
}  
Console.WriteLine($"{name2} vs {name1}");

while (hp1 > 0 && hp2 > 0)
{
    Console.WriteLine($"{name1} attackerar {name2}  ");
    int dmg1 = Random.Shared.Next(45);
    hp2 -= dmg1;
    Console.WriteLine($"{name1} Har {hp1} hp kvar medans {name2} har {hp2} kvar");
    Console.WriteLine($"{name1} Gjorde {dmg1} skada");
    Console.ReadLine();

    int dmg2 = Random.Shared.Next(45);
    hp1 -= dmg2;
    Console.WriteLine($"{name2} Har {hp2} hp kvar medans {name1} har {hp1} kvar");
    Console.WriteLine($"{name2} Gjorde {dmg2} skada");
    Console.ReadLine();

    hp2 = Math.Max(hp2, 0); // Gör så att ifall hp är negativt så sätts den upp till 0
    hp1 = Math.Max(hp1, 0);
}
if (hp2 == 0) 
{
    Console.WriteLine($"{name1} har besegrat {name2}");
}
else if (hp1 == 0)
{
    Console.WriteLine($"");
    Console.WriteLine($"{name2} har besegrat {name1}");

}
Console.ReadLine();