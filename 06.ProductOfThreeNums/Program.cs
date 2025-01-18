using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks.Dataflow;

int a = int.Parse(Console.ReadLine()); 
int b = int.Parse(Console.ReadLine()); 
int c = int.Parse(Console.ReadLine());

int sum = a * b * c;

if (sum < 0)
{
    Console.WriteLine("negative");
   
}else if (sum > 0)
{
    Console.WriteLine("positive");
}
else { Console.WriteLine("zero"); }