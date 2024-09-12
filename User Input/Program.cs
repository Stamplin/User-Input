//part 1
using System;
using System.Runtime.ExceptionServices;

string name;
int age;
double money;
Console.WriteLine("Hello. What is your name?");
name = Console.ReadLine();
Console.WriteLine("hi, " + name + "! How old are you?");
int.TryParse(Console.ReadLine(), out age);
Console.WriteLine("You sure don't look " + age + " How much do you make " + name + "?");
double.TryParse(Console.ReadLine(), out money);
Console.WriteLine(money.ToString("C") + "! Wow that's a alot of money.");
Console.WriteLine("press enter to move to part 2");
Console.ReadLine();
Console.Clear();

//part 2
string fname, lname, login;
int grade, id;
double average;
Console.WriteLine("Oi fill out da form for a chance to win 10,000$ dollars.");
Console.WriteLine("First name: "); fname = Console.ReadLine();
Console.WriteLine("Last name: "); lname = Console.ReadLine();
Console.WriteLine("Grade(9-12): "); fname = Console.ReadLine();


Console.ReadLine();
