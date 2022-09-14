using System;

namespace OperatorsExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            // exercise 1 ---------------

            var a = 17;

            var b = 4;

            var div = a / b;
            var mod = a % b;

            Console.WriteLine($"{a}/{b} is {div} remainder {mod}");

            // exercise 2 ---------------

            var r = 20;
            var pi = Math.PI;

            var areaOfCircle = pi * (r * r);

            Console.WriteLine($"The area of a circle with a radius of {r} is {areaOfCircle}");


        }
    }
}

