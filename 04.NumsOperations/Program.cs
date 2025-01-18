using System.Transactions;

double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());
string op = (Console.ReadLine());
double result = 0;


if (op == "+") { 
    result = a + b;
    Console.WriteLine($"{a} {op} {b} = {result:F2}");
} 
else if (op == "-")
{
    result = a - b;
    Console.WriteLine($"{a} {op} {b} = {result:F2}");
        }
else if (op == "*") { 
    result = a * b;
    Console.WriteLine($"{a} {op} {b} = {result:F2}");
}
else if(op == "/")
{

result = a / b;
    Console.WriteLine($"{a} {op} {b} = {result:F2}");
}