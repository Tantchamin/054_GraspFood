using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int BreakfastSet = 5;
            int WeekendSet = 2;
            int Coffee = 3;

            int day = int.Parse(Console.ReadLine());
            int time = int.Parse(Console.ReadLine());
            string food = Console.ReadLine();
            while (food != "End")
            {
                if (day == 1)
                {
                    while (food != "Breakfast Set" && food != "Coffee" && food != "Weekend Set" && food != "End")
                    {
                        Console.WriteLine("Please enter a valid menu");
                        food = Console.ReadLine();
                    }
                    if (time >= 8 && time <= 11 && food == "Breakfast Set")
                    {
                        if (BreakfastSet >= 1)
                        {
                            BreakfastSet -= 1;
                            food = Console.ReadLine();
                        }
                        else if (BreakfastSet <= 0)
                        {
                            Console.WriteLine("Sorry your order is out of stock");
                            food = Console.ReadLine();
                        }
                    }
                    else if (time > 11 && food == "Breakfast Set")
                    {
                        Console.WriteLine("Sorry your order is not available");
                        food = Console.ReadLine();
                    }
                    else if (food == "Coffee")
                    {
                        if (Coffee >= 1)
                        {
                            Coffee -= 1;
                            food = Console.ReadLine();
                        }
                        else if (Coffee <= 0)
                        {
                            Console.WriteLine("Sorry your order is out of stock");
                            food = Console.ReadLine();
                        }
                    }
                    else if ("Weekend Set" == food)
                    {
                        Console.WriteLine("Sorry your order is not available");
                        food = Console.ReadLine();
                    }

                }
                else if (day == 2)
                {
                    while (food != "Breakfast Set" && food != "Coffee" && food != "Weekend Set" && food != "End")
                    {
                        Console.WriteLine("Please enter a valid menu");
                        food = Console.ReadLine();
                    }
                    if (time >= 8 && time <= 11 && food == "Breakfast Set")
                    {
                        if (BreakfastSet >= 1)
                        {
                            BreakfastSet -= 1;
                            food = Console.ReadLine();
                        }
                        else if (BreakfastSet <= 0)
                        {
                            Console.WriteLine("Sorry your order is out of stock");
                            food = Console.ReadLine();
                        }
                    }
                    else if (time > 11 && food == "Breakfast Set")
                    {
                        Console.WriteLine("Sorry your order is not available");
                        food = Console.ReadLine();
                    }
                    else if (food == "Coffee")
                    {
                        if (Coffee >= 1)
                        {
                            Coffee -= 1;
                            food = Console.ReadLine();
                        }
                        else if (Coffee <= 0)
                        {
                            Console.WriteLine("Sorry your order is out of stock");
                            food = Console.ReadLine();
                        }
                    }
                    else if ("Weekend Set" == food)
                    {
                        Console.WriteLine("Sorry your order is not available");
                        food = Console.ReadLine();
                    }
                }
                else if (day == 3)
                {
                    while (food != "Breakfast Set" && food != "Coffee" && food != "Weekend Set" && food != "End")
                    {
                        Console.WriteLine("Please enter a valid menu");
                        food = Console.ReadLine();
                    }
                    if (time >= 8 && time <= 11 && food == "Breakfast Set")
                    {
                        if (BreakfastSet >= 1)
                        {
                            BreakfastSet -= 1;
                            food = Console.ReadLine();
                        }
                        else if (BreakfastSet <= 0)
                        {
                            Console.WriteLine("Sorry your order is out of stock");
                            food = Console.ReadLine();
                        }
                    }
                    else if (time > 11 && food == "Breakfast Set")
                    {
                        Console.WriteLine("Sorry your order is not available");
                        food = Console.ReadLine();
                    }
                    else if (food == "Coffee")
                    {
                        if (Coffee >= 1)
                        {
                            Coffee -= 1;
                            food = Console.ReadLine();
                        }
                        else if (Coffee <= 0)
                        {
                            Console.WriteLine("Sorry your order is out of stock");
                            food = Console.ReadLine();
                        }
                    }
                    else if ("Weekend Set" == food)
                    {
                        Console.WriteLine("Sorry your order is not available");
                        food = Console.ReadLine();
                    }
                }
                else if (day == 4)
                {
                    while (food != "Breakfast Set" && food != "Coffee" && food != "Weekend Set" && food != "End")
                    {
                        Console.WriteLine("Please enter a valid menu");
                        food = Console.ReadLine();
                    }
                    if (time >= 8 && time <= 11 && food == "Breakfast Set")
                    {
                        if (BreakfastSet >= 1)
                        {
                            BreakfastSet -= 1;
                            food = Console.ReadLine();
                        }
                        else if (BreakfastSet <= 0)
                        {
                            Console.WriteLine("Sorry your order is out of stock");
                            food = Console.ReadLine();
                        }
                    }
                    else if (time > 11 && food == "Breakfast Set")
                    {
                        Console.WriteLine("Sorry your order is not available");
                        food = Console.ReadLine();
                    }
                    else if (food == "Coffee")
                    {
                        if (Coffee >= 1)
                        {
                            Coffee -= 1;
                            food = Console.ReadLine();
                        }
                        else if (Coffee <= 0)
                        {
                            Console.WriteLine("Sorry your order is out of stock");
                            food = Console.ReadLine();
                        }
                    }
                    else if ("Weekend Set" == food)
                    {
                        Console.WriteLine("Sorry your order is not available");
                        food = Console.ReadLine();
                    }
                }
                else if (day == 5)
                {
                    while (food != "Breakfast Set" && food != "Coffee" && food != "Weekend Set" && food != "End")
                    {
                        Console.WriteLine("Please enter a valid menu");
                        food = Console.ReadLine();
                    }
                    if (time >= 8 && time <= 11 && food == "Breakfast Set")
                    {
                        if (BreakfastSet >= 1)
                        {
                            BreakfastSet -= 1;
                            food = Console.ReadLine();
                        }
                        else if (BreakfastSet <= 0)
                        {
                            Console.WriteLine("Sorry your order is out of stock");
                            food = Console.ReadLine();
                        }
                    }
                    else if (time > 11 && food == "Breakfast Set")
                    {
                        Console.WriteLine("Sorry your order is not available");
                        food = Console.ReadLine();
                    }
                    else if (food == "Coffee")
                    {
                        if (Coffee >= 1)
                        {
                            Coffee -= 1;
                            food = Console.ReadLine();
                        }
                        else if (Coffee <= 0)
                        {
                            Console.WriteLine("Sorry your order is out of stock");
                            food = Console.ReadLine();
                        }
                    }
                    else if ("Weekend Set" == food)
                    {
                        Console.WriteLine("Sorry your order is not available");
                        food = Console.ReadLine();
                    }
                }
                else if (day == 6)
                {
                    while (food != "Breakfast Set" && food != "Coffee" && food != "Weekend Set" && food != "End")
                    {
                        Console.WriteLine("Please enter a valid menu");
                        food = Console.ReadLine();
                    }
                    if (time >= 8 && time <= 11 && food == "Breakfast Set")
                    {
                        if (BreakfastSet >= 1)
                        {
                            BreakfastSet -= 1;
                            food = Console.ReadLine();
                        }
                        else if (BreakfastSet <= 0)
                        {
                            Console.WriteLine("Sorry your order is out of stock");
                            food = Console.ReadLine();
                        }
                    }
                    else if (time > 11 && food == "Breakfast Set")
                    {
                        Console.WriteLine("Sorry your order is not available");
                        food = Console.ReadLine();
                    }
                    else if (food == "Coffee")
                    {
                        if (Coffee >= 1)
                        {
                            Coffee -= 1;
                            food = Console.ReadLine();
                        }
                        else if (Coffee <= 0)
                        {
                            Console.WriteLine("Sorry your order is out of stock");
                            food = Console.ReadLine();
                        }
                    }
                    else if ("Weekend Set" == food)
                    {
                        if (WeekendSet >= 1)
                        {
                            WeekendSet -= 1;
                            food = Console.ReadLine();
                        }
                        else if (WeekendSet <= 0)
                        {
                            Console.WriteLine("Sorry your order is out of stock");
                            food = Console.ReadLine();
                        }
                    }
                }
                else if (day == 7)
                {
                    while (food != "Breakfast Set" && food != "Coffee" && food != "Weekend Set" && food != "End")
                    {
                        Console.WriteLine("Please enter a valid menu");
                        food = Console.ReadLine();
                    }
                    if (time >= 8 && time <= 11 && food == "Breakfast Set")
                    {
                        if (BreakfastSet >= 1)
                        {
                            BreakfastSet -= 1;
                            food = Console.ReadLine();
                        }
                        else if (BreakfastSet <= 0)
                        {
                            Console.WriteLine("Sorry your order is out of stock");
                            food = Console.ReadLine();
                        }
                    }
                    else if (time > 11 && food == "Breakfast Set")
                    {
                        Console.WriteLine("Sorry your order is not available");
                        food = Console.ReadLine();
                    }
                    else if (food == "Coffee")
                    {
                        if (Coffee >= 1)
                        {
                            Coffee -= 1;
                            food = Console.ReadLine();
                        }
                        else if (Coffee <= 0)
                        {
                            Console.WriteLine("Sorry your order is out of stock");
                            food = Console.ReadLine();
                        }
                    }
                    else if ("Weekend Set" == food)
                    {
                        if (WeekendSet >= 1)
                        {
                            WeekendSet -= 1;
                            food = Console.ReadLine();
                        }
                        else if (WeekendSet <= 0)
                        {
                            Console.WriteLine("Sorry your order is out of stock");
                            food = Console.ReadLine();
                        }
                    }
                }
            }
        }
    }
}
