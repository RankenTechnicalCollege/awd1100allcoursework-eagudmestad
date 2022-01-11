// See https://aka.ms/new-console-template for more information

const double KM_PER_MILE = 1.6;

//Prompt the user to ask for a degree in F
//To ask the user a question you use Console.WriteLine();
Console.WriteLine("What degree in Fahrenheit should we convert to Celcius?");

//Store the user input into a variable
double fahrenheit = Convert.ToDouble(Console.ReadLine());

//Perform Math to calc Celcius
double celsius = (fahrenheit - 32) * 5 / 9;

//Output the Celcius
Console.WriteLine("{0} fahrenheit is {1:N4} celsius", fahrenheit, celsius);