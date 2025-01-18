 string season = Console.ReadLine();
 string type = Console.ReadLine();
 int daysCount = int.Parse(Console.ReadLine());
double price = 0;

if (season == "Spring" && type == "Hotel")
{
    price = (30 * daysCount) * 0.8;
} else if (season == "Spring" && type == "Camping")
{
    price = (10 * daysCount) * 0.8;
}else if (season == "Summer" && type == "Hotel")
{
    price = 50*daysCount;
} else if (season == "Summer" && type == "Camping")
{
    price = 30 * daysCount;
}
else if(season == "Autumn" && type == "Hotel")
{
    price = (20 * daysCount) * 0.7;
}else if (season == "Autumn" && type == "Camping")
{
    price = (15 * daysCount) * 0.7;
}
else if (season == "Winter" && type == "Hotel")
{
    price = (40 * daysCount) * 0.9;
}
else if (season == "Winter" && type == "Camping")
{
    price = (10 * daysCount) * 0.9;
}
Console.WriteLine($"{price:F2}");