// See https://aka.ms/new-console-template for more information

int age = 5;

age++;

//modulus is the remainder
double modulus = 21 % 2;

double balance = 1000;

Console.WriteLine("How much did you deposit?");
double deposit = Convert.ToDouble(Console.ReadLine());

balance += deposit;

Console.WriteLine("Your new balance is {0:C}", balance);

