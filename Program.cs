using System;
using static System.Console;

namespace lesson___2_7_2
{
    internal class Program
    {
        static void Main(string[] args)  // точка входа
        {
            string Sprogramming = "3";
            string Smathematics = "4";
            string Sphysics = "5";
            

            WriteLine($"\nбаллы по программированию: {Sprogramming} \nбаллы по математике: {Smathematics} \nбаллы по физике: {Sphysics}");  // все предметы

            int a = 3; 
            int b = 4; 
            int c = 5;
            a += b + c; // сумма баллов по всем предметам

            WriteLine($"\nсумма баллов по всем предметам: {a}");
            
            int d = 3;
            int e = 4;
            int f = 5;
            int g = (d + e + f)/3; // средний балл по всем предметам

            WriteLine($"\nсредний балл по всем предметам: {g}");


            ReadKey();  // задержка
        }
    }
}