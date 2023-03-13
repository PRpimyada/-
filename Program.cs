using System;
static void Main(string[] args) 
{
    //int week = 7 Day; 
 Console.WriteLine("Days of the week (1-7 Day):");
  int day = int.Parse(Console.ReadLine());
/*Console.WriteLine("sunday");
Console.WriteLine("monday");
Console.WriteLine("Tuesday");
Console.WriteLine("Wednesday");
Console.WriteLine("Friday");
Console.WriteLine("Saturday");*/
Console.WriteLine("Time of Day 8-18 (8.00 - 18.00 น.) : ");
 int Time = int.Parse(Console.ReadLine());
if (Day < 7  Day > 1 , Time > 8 ,Time < 18 ); {
} else { Console.WriteLine("Menu");
 Console.WriteLine("1.) Breakfast Set 5");
 Console.WriteLine ("2.) Weekend Set 6");
 Console.WriteLine ("3.)Coffee set 3");
}
    
}






/*using System;
class Program {
    static void Main(string[] args) {
        Console.Write("Input day of week (Write only 1-7 (Mon-Sun)): ");
        int day = int.Parse(Console.ReadLine());

        Console.Write("Input time of day (Write only 8-18 (8:00 - 18:00)): ");
        int time = int.Parse(Console.ReadLine());

        if (day < 1 || day > 7 || time < 8 || time > 18) {
            Console.WriteLine("Sorry your order is not available");
        } else {
            int breakfast = 5;
            int weekend = 2;
            int coffee = 3;

            Console.WriteLine();
            Console.WriteLine("Menu");
            Console.WriteLine("1.) Breakfast Set (You can buy {0} sets per day)", breakfast);
            Console.WriteLine("2.) Weekend Set (You can buy {0} sets per day)", weekend);
            Console.WriteLine("3.) Coffee (You can buy {0} per day)", coffee);
            Console.WriteLine();

            while (true) {
                Console.Write("What do you want to buy? (Use only capital letters BREAKFAST, WEEKEND, COFFEE If you finished order input END): ");
                string food = Console.ReadLine().ToUpper();
                if (food == "BREAKFAST") {
                    if (breakfast > 0 && time <= 11) {
                        breakfast--;
                        Console.WriteLine("Order Complete (You can buy Breakfast Set only {0} more)", breakfast);
                    } else if (time > 11) {
                        Console.WriteLine("Sorry Breakfast Set can only be sold until 11:00");
                    } else {
                        Console.WriteLine("Sorry your order is out of stock");
                    }
                } else if (food == "WEEKEND") {
                    if (weekend > 0) {
                        weekend--;
                        Console.WriteLine("Order Complete (You can buy Weekend Set only {0} more)", weekend);
                    } else {
                        Console.WriteLine("Sorry your order is out of stock");
                    }
                } else if (food == "COFFEE") {
                    if (coffee > 0) {
                        coffee--;
                        Console.WriteLine("Order Complete (You can buy Coffee only {0} more)", coffee);
                    } else {
                        Console.WriteLine("Sorry your order is out of stock");
                    }
                } else if (food == "END") {
                    Console.WriteLine("Thank you");
                    break;
                } else {
                    Console.WriteLine("Please enter a valid menu");
                }
                if (breakfast == 0 && weekend == 0 && coffee == 0) {
                    Console.WriteLine("Sorry your order is out of stock");
                    break;
                }
            }
        }
    }
}*/
