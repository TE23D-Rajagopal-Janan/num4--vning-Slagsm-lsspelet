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
Console.WriteLine("Vad heter spelare 1");
string name2 = Console.ReadLine();
while (name2 == "") 
{
    Console.WriteLine("Skriv in ditt namn/Write your name");
    name2 = Console.ReadLine();
}  
Console.WriteLine($"Hej {name2} och {name1}");

while (hp1 > 1 && hp2 > 1)
{
    Console.WriteLine($"{name1} attakerar {name2}  ");
    int dmg1 = Random.Shared.Next(30);
    hp2 -= dmg1;
    Console.WriteLine($"{name1} Har {hp1} hp kvar medans {name2} har {hp2} kvar");
    Console.ReadLine();

int dmg2 = Random.Shared.Next(30);
    hp1 = -dmg2;
    Console.WriteLine($"{name2} Har {hp2} hp kvar medans {name1} har {hp1} kvar");
    Console.ReadLine();
}
if (hp2 == 0) 
{
    Console.WriteLine($"(name1) har besegrat (name2)");
}
else if (hp1 == 0)
{
    Console.WriteLine($"(name2) har besegrat (name1)");

}
Console.ReadLine();