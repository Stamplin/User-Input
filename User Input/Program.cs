//test with string

using System;

string userName;
Console.WriteLine("enter you name");
userName = Console.ReadLine();
Console.WriteLine("so your name is " +  userName);
Console.ReadLine();

//test with numbers

int aGe;
Console.WriteLine("how old are you?");
aGe = Console.ReadLine();
Console.WriteLine(int32.TryParse(Console.ReadLine(), out aGe));
Console.WriteLine("AYO WHAT THE " + aGe + " YOU AINT OLD ENOUGH YET FOOL");
Console.ReadLine();

