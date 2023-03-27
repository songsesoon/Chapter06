using System;

namespace OptionnalParamter
{
    class MainApp
    {
        static void PrintProfile(string name, string phone = "")
        {
            Console.WriteLine($"Name: {name}, Phone: {phone}");
        }

        static void Main(string[] args)
        {
            PrintProfile("중근");
            PrintProfile("관순", "010-123-1234");
            PrintProfile("봉길");
            PrintProfile("동주", phone: "010-789=7890");
        }
    }
}