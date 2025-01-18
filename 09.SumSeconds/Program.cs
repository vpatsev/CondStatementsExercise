int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

int time = a + b + c;

int minutes = time / 60;
int seconds = time % 60;

Console.WriteLine($"{minutes}:{seconds:D2}");





