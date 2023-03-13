using System;
class Program {
    static void Main(string[] args) {
        Console.Write("Day of Week (1-7):");
        int days = int.Parse(Console.ReadLine());
        Console.Write("Time of Day (8-18):");
        int times = int.Parse(Console.ReadLine());
        int b_count = 5;
        int w_count = 2;
        int c_count = 3;
        Console.WriteLine("Menu");
        Console.WriteLine("Breakfast Set:5");
        Console.WriteLine("Weekend Set:2");
        Console.WriteLine("Coffee:3");
        for (;;) {
            Console.Write("Your order (BREAKFAST_SET,WEEKEND_SET,COFFEE):");
            string all = Console.ReadLine().ToUpper();
            switch (all) {
                case "BREAKFAST_SET":
                    if (b_count > 0 && times < 12) {
                        b_count--;
                        Console.WriteLine("Breakfast Set:{0})", b_count);
                    } else if (times > 11) {
                        Console.WriteLine("Sorry your order is not available");
                    } else {
                        Console.WriteLine("Sorry your order is out of stock");
                    }
                    break;
                case "WEEKEND_SET":
                    if (w_count > 0 && days > 5) {
                        w_count--;
                        Console.WriteLine("Weekend Set:{0})", w_count);
                    } else if (days < 6) {
                        Console.WriteLine("Sorry your order is not available");
                    } else {
                        Console.WriteLine("Sorry your order is out of stock");
                    }
                    break;
                case "COFFEE":
                    if (c_count > 0) {
                        c_count--;
                        Console.WriteLine("Coffee:{0})", c_count);
                    } else {
                        Console.WriteLine("Sorry your order is out of stock");
                    }
                    break;
                case "END":
                    Console.WriteLine("Goodbye");
                    return;
                default:
                    Console.WriteLine("Please enter a valid menu");
                    break;
            }
            if (b_count == 0 && w_count == 0 && c_count == 0) {
                Console.WriteLine("Sorry your order is out of stock");
                break;
            }
        }
    }
}
