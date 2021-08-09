using System;

namespace _03.KindergardenCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string groupType = Console.ReadLine();
            int children = int.Parse(Console.ReadLine());
            int nightStay = int.Parse(Console.ReadLine());
            string kindOfSport = string.Empty;

            double nightPrice = 0;

            switch (groupType)
            {
                case "boys":
                case "girls":
                    if (season == "winter")
                    {
                        nightPrice = nightStay * 9.6;

                        if (groupType == "boys")
                        {
                            kindOfSport = "Box";
                        }
                        else if (groupType == "girls")
                        {
                            kindOfSport = "Gymnastics";
                        }
                        else
                        {
                            kindOfSport = "Snowboard";
                        }
                    }
                    else if (season == "spring")
                    {
                        nightPrice = nightStay * 7.2;

                        if (groupType == "boys")
                        {
                            kindOfSport = "Tennis";
                        }
                        else if (groupType == "girls")
                        {
                            kindOfSport = "Aerobics";
                        }
                        else
                        {
                            kindOfSport = "Cycling";
                        }
                    }
                    else
                    {
                        nightPrice = nightStay * 15;

                        if (groupType == "boys")
                        {
                            kindOfSport = "Football";
                        }
                        else if (groupType == "girls")
                        {
                            kindOfSport = "Volleyball";
                        }
                        else
                        {
                            kindOfSport = "Swimming";
                        }
                    }
                    break;
                case "mix":
                    if (season == "winter")
                    {
                        nightPrice = nightStay * 10;
                        kindOfSport = "Snowboard";
                    }
                    else if (season == " spring")
                    {
                        nightPrice = nightStay * 9.5;
                        kindOfSport = "Cycling";
                    }
                    else
                    {
                        nightPrice = nightStay * 20;
                    }
                    break;
                default:
                    break;
            }

            double totalPrice = children * nightPrice;
            double discount = 0;

            if (children >= 50)
            {
                discount = totalPrice / 2;
            }
            else if (children >= 20 && children < 50)
            {
                discount = totalPrice - (totalPrice * 0.15);
            }
            else if (children >= 10 && children < 20)
            {
                discount = totalPrice - (totalPrice * 0.1);
            }
            else
            {
                discount = totalPrice;
            }

            Console.WriteLine($"{kindOfSport} {discount:F2} BGN");
        }
    }
}
