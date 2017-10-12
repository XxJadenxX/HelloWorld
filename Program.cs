using System;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
           Start ();  
        }
        public static void Start()
        {
			Console.WriteLine("Write 2 numbers");
			float number1 = float.Parse(Console.ReadLine());
			float number2 = float.Parse(Console.ReadLine());

			Console.WriteLine("Select an option\n1.-Add\n2.-Substract\n3.-Multiply\n4.-Divide\n5.-Exit");

			int option = int.Parse(Console.ReadLine());

			EvaluateOption(option, number1, number2);

			Console.WriteLine(option);
        }

        public static float AddTwoNumbers(float n1, float n2)
        {
            float result = n1 + n2;

            return result;
        }
		public static float SubstractTwoNumbers(float n1, float n2)
		{
			float result = n1 - n2;

			return result;
		}

		public static float MultiplyTwoNumbers(float n1, float n2)
		{
			float result = n1 * n2;

			return result;
		}
		public static float DivideTwoNumbers(float n1, float n2)
		{
			float result = n1 / n2;

			return result;
		}

        public static void EvaluateOption(int option, float n1, float n2)
        {
            /*if (option == 1)
            {
                Console.WriteLine("Result of the addition" + AddTwoNumbers(n1, n2));
            } 
            else if (option == 2)
            {
                Console.WriteLine("Result of the Substraction" + SubstractTwoNumbers(n1, n2));
            }
			else if (option == 3)
			{
				Console.WriteLine("Result of the Multiplication" + MultiplyTwoNumbers(n1, n2));
			}
			else if (option == 4)
			{
				Console.WriteLine("Result of the division" + DivideTwoNumbers (n1, n2));
			}
            else if(option ==5){
                return;
            }
            else{
               Console.WriteLine("Invalid Option");  
            }*/

            switch (option)
            {
            case 1:
                    Console.WriteLine("Result of the addition" + AddTwoNumbers(n1, n2));
                    break;

                  
            }

            Start();
        }

    }
}
