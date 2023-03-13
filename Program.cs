using System;
namespace workshopweek4
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int time = int.Parse(Console.ReadLine());
            int Bset = 5;
            int Wset = 2;
            int cf = 3;

            while (true)
            {
                string menu = Console.ReadLine();

                if (menu == "Breakfast Set" || menu == "Weekend Set" || menu == "Coffee")
                {

                    if (menu == "Breakfast Set")
                    {
                        if (Bset != 0 && time < 11)
                        {
                            Bset--;
                        }
                        else if (Bset == 0)
                        {
                            Console.WriteLine("Sorry your order is out of stock");
                        }
                        else
                        {
                            Console.WriteLine("Sorry your order is not available");
                        }

                    }
                    else if (menu == "Weekend Set")
                    {
                        if (Wset != 0 && day == 6 || Wset != 0 && day == 7)
                        {
                            Wset--;
                        }
                        else if (Wset == 0)
                        {
                            Console.WriteLine("Sorry your order is out of stock");
                        }
                        else
                        {
                            Console.WriteLine("Sorry your order is not available");
                        }

                    }
                    else if (menu == "Coffee")
                    {
                        if (cf != 0)
                        {
                            cf--;
                        }
                        else if (cf == 0)
                        {
                            Console.WriteLine("Sorry your order is out of stock");
                        }
                    }
                }
                else if (menu == "End")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid menu");
                }


            }


        }

    }
}
