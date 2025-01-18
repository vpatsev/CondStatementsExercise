using System.ComponentModel.Design;

int temp = int.Parse(Console.ReadLine());
string dayTime = Console.ReadLine();
string clothing = "";
string shoes = "";
if (dayTime == "Morning")
{
    if (temp >= 10 && temp <= 18)
    {
        clothing = "Sweatshirt";
        shoes = "Sneakers";
    }
    else if (temp > 18 && temp <= 24)
    {
        clothing = "Shirt";
        shoes = "Moccasins";
    }
    else if (temp >= 25)
    {
        clothing = "T-Shirt";
        shoes = "Sandals";


    }

}
else if (dayTime == "Afternoon")
{
    if (temp >= 10 && temp <= 18)
    {
        clothing = "Shirt";
        shoes = "Moccasins";
    }
    else if (temp > 18 && temp <= 24)
    {
        clothing = "T-Shirt";
        shoes = "Sandals";
    }
    else if (temp >= 25)
    {
        clothing = "Swim Suit";
        shoes = "Barefoot";
    }
}
else if (dayTime == "Evening")
{
    if (temp >= 10 && temp <= 18)
    {
        clothing = "Shirt";
        shoes = "Moccasins";
    }
    else if (temp > 18 && temp <= 24)
    {
        clothing = "Shirt";
        shoes = "Moccasins";
    }
    else if (temp >= 25)
    {
        clothing = "Shirt";
        shoes = "Moccasins";
    }
}
Console.WriteLine($"It's {temp} degrees, get your {clothing} and {shoes}.");



