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
string firstName, lastName, login;
int grade, ID;
double average;
Console.WriteLine("Please fill out da form for a chance to win 10,000$ dollars!");
Console.WriteLine("What is your first name? ");
firstName = Console.ReadLine();
Console.WriteLine("What is your last name? ");
lastName = Console.ReadLine();
Console.WriteLine("What grade are you in? ");
Int32.TryParse(Console.ReadLine(), out grade);
Console.WriteLine("What is yout student ID? ");
Int32.TryParse(Console.ReadLine(), out ID);
Console.WriteLine("what is your login?");
login = Console.ReadLine();
Console.WriteLine("What is your average? "); double.TryParse(Console.ReadLine(), out average);
Console.WriteLine(); //space to seprate the two spaces
Console.WriteLine("Your information:");
Console.WriteLine("Login:\t\t" + login);
Console.WriteLine("ID:\t\t" + ID);
Console.WriteLine("Name:\t\t" + firstName + ", " + lastName);
Math.Round(average, 1);
Console.WriteLine("Average:\t" + average + "%");
Console.WriteLine("Grade:\t\t" + grade);
Console.WriteLine("press enter to move to part 3");
Console.ReadLine();
Console.Clear();

//part 3:
string p3Name;
int p3Age;
Console.WriteLine("Hey! What is your name?");
p3Name = Console.ReadLine();
Console.WriteLine("How old are you?");
Int32.TryParse(Console.ReadLine(), out p3Age);
Console.WriteLine("Did you know in 5 years you will be " + (p3Age + 5) + " and 5 years ago you were " + (p3Age - 5));
Console.WriteLine("press enter to move to part 4");
Console.ReadLine();
Console.Clear();

//part 4:
double calInput, calInput2, calInput3;
Console.WriteLine("Welcome to the Dumb Calculator \n Please input 3 numbers you would like to added and devided by 2: ");
Console.WriteLine("input your first number: "); double.TryParse(Console.ReadLine(), out calInput);
Console.WriteLine("input your second number: "); double.TryParse(Console.ReadLine(), out calInput2);
Console.WriteLine("input your third number: "); double.TryParse(Console.ReadLine(), out calInput3);
Console.Clear();
Console.WriteLine("your 3 numbers added is " + (calInput + calInput2 + calInput3) + ", divided by two is: " + ((calInput + calInput2 + calInput3)/2));
Console.WriteLine("press enter to move to part 5");
Console.ReadLine();
Console.Clear();

//part 5
string item1, item2;
double price1, price2, total, discount, tax, subtotal;
Console.WriteLine("Hello! Please enter the name and price of your items.");
Console.WriteLine("Please name your first item:");
item1 = Console.ReadLine();
Console.WriteLine("Enter the price of your first item:");
double.TryParse(Console.ReadLine(), out price1);
Console.WriteLine("Please enter the name of your second item:");
item2 = Console.ReadLine();
Console.WriteLine("Enter the price of your second item");
double.TryParse(Console.ReadLine(), out price2);
Console.WriteLine("Press \"enter\" to proceed:");
Console.ReadLine();
Console.Clear();
//output
Console.WriteLine("Sales Receipt");
Console.WriteLine("Item 1: " + item1);
Console.WriteLine("Price: $" + price1);
Console.WriteLine("Item 2: " + item2);
Console.WriteLine("Price: $" + price2);
Console.WriteLine("==========================");
total = price1 + price2;
Console.WriteLine("Total: $" + total);
discount = total * 0.2;
Console.WriteLine("Discount (20%): $" + discount);
subtotal = total - discount;
Console.WriteLine("Subtotal: $" + subtotal);
tax = subtotal * 0.13;
Console.WriteLine("Tax (13%): $" + tax);
Console.WriteLine("==========================");
Console.WriteLine("Total Owed: $" + (subtotal + tax));
Console.ReadLine();
