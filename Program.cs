using System;

namespace HelloWorld
{
    class MainClass
    {
        public static
            Console.WriteLine("Write 2 numbers");
        float number1 = float.Parse(Console.ReadLine());
        float number2 = float.Parse(Console.ReadLine());
        Console.WriteLine(AddTwoNumbers(number1, number2));

        }
    public static float AddTwoNumbers(float n1, float n2)
    {
        float result = n1 + n2;

        return result;
    }