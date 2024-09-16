int hp1 = 100;
int hp2 = 100;
int dmg1 = Random.Shared.Next(80);
int dmg2 = Random.Shared.Next(80);
string name1;
string name2;
string ans1;

Console.WriteLine("Vad heter spelare 1");
name1 = Console.ReadLine ();
Console.WriteLine("Vad heter spelare 2");
name2 = Console.ReadLine ();

while (hp1 > 0) 
{
Console.WriteLine ($"{name1} attakerar {name2}  ");
hp2 = dmg1 -Random.Shared.Next(80); 
Console.WriteLine ($"{name1} Har {hp1} hp kvar medans {name2} har {hp2} kvar");

}




Console.ReadLine ();