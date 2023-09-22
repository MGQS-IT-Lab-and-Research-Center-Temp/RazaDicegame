// See https://aka.ms/new-console-template for more information
using System.Drawing;
using System.Reflection.Metadata;

Console.Write("    -------A Simple Dice Game-------\nEnter your nickname: ");
String? nickname = Console.ReadLine();
Console.Write($"\nHi {nickname}, Let's play a dice game.\nFor the total number you get you will have a gift.\n--------------------------------------------------\nTo begin, Input \"S\" or \"Start\": ");
String? input = Console.ReadLine();
Console.Write("\n========================================\n");

const int double_point = 2;						
const int triple_point = 6;

string gift = "No Prize";
string gift1 = "A Balloon";
string gift2 = "An Exercise Book";
string gift3 = "5000mah Powerbank";
string gift4 = "A visit to Silverbird Galleria";
string gift5 = "Samsung A21";
string gift6 = "All the Items including Iphone 15";

Random random = new Random();
int dice_one = random.Next(0, 7);
int dice_two = random.Next(0, 7);
int dice_three = random.Next(0, 7);
int point = dice_one + dice_two + dice_three; 

if (!(input.Equals("s", StringComparison.OrdinalIgnoreCase) || input.Equals("start", StringComparison.OrdinalIgnoreCase)))
{
    Console.Write("Input a valid response");
    while ((!(input.Equals("s", StringComparison.OrdinalIgnoreCase) || input.Equals("start", StringComparison.OrdinalIgnoreCase))))
    {
        Console.WriteLine("Input valid response: ");
    }
}
else
{

    if(dice_one == dice_two && dice_two == dice_three)
    {
        int bonus3 = point + triple_point;
        Console.Write($"Dice one: {dice_one} Dice Two: {dice_two} Dice Three: {dice_three}\nYour point is: {point}\nYour bonus point is: {triple_point}\nYour Total point is: {bonus3}");
    }

    if(dice_one == dice_two || dice_two == dice_three || dice_one == dice_three)
    {
        int bonus2 = point + double_point;
        Console.Write($"Dice one: {dice_one} Dice Two: {dice_two} Dice Three: {dice_three}\nYour point is: {point}\nYour bonus point is: {double_point}\nYour Total point is: {bonus2}\n");
    }

    else
    {
        int bonus = point;
        Console.WriteLine($"Dice one: {dice_one} Dice Two: {dice_two} Dice Three: {dice_three}\nYour point is: {point}\nYou have no bonus = 0\nYour Total Point is {bonus} ");
    }
    
if (point >= 3 && point <= 9)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine($"You win {gift}");
    Console.ResetColor();
}
else if (point >= 10 && point <= 13)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine($"You win {gift1}");
    Console.ResetColor();
}
else if (point >= 14 && point <= 16)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"You win {gift2}");
    Console.ResetColor();
}
else if (point == 17)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"You win {gift3}");
    Console.ResetColor();
}
else if (point >= 18 && point <= 20)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"You win {gift4}");
}
else if (point == 21)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"You win {gift5}");
    Console.ResetColor();
}
else if (point >= 22 && point <= 24)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine($"You win {gift6}");
    Console.ResetColor();
}
}
// Console.WriteLine("Do you wish to continue?\nYes / No");
// string reply = Console.ReadLine();
// if 