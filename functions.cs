using System;
					
public class Program
{
	public static void Main()
	{
        class Program
        {
            static void SayHello()
            {
                Console.Writeline("Welcome Friends!")
                Console.Writeline("Have a nice day!")
            }
            

            static void Welcome(string name)
            {
                Console.Writeline("What is your name?");
                string name = Console.Readline();


                Console.Writeline("Welcome" + name);
                Console.WriteLine("Have a nice day!")
            }
            static void AddTwoNums(int n1, int n2)
            {
                int n1 = 15;
                int n2 = 16;

                int n3 = n1 + n2;
                
                Console.Writeline(n3)
            }
            static void Spaces(string write)
            {
                Console.Writeline("Please input a string:")

                int CountSpaces = mystring.Count(Char.IsWhiteSpace);

                Console.Writeline(CountSpaces);
                

            }
            static void array()
            {
                double sum=0, avg=0;
                double[] numbers = { 10, 20, 50, 40};
                for(int i=0;i<numbers.Length;i++)
            {
                sum += numbers[i];
            }    
                avg = sum / numbers.Length;
                Console.WriteLine("The Sum is : "+sum);
                Console.WriteLine("The Average is : "+avg);
            
                Console.ReadKey();
            }
            
            static void Swap()
            {
                Console.Writeline("Enter a number:");
                int num1 = Console.Readline();
                
                Console.WriteLine("Enter another number:");
                int num2 = Console.Readline();

                int num1 = num2;

                int num2 = num1;

                Console.Writeline("Now the 1st number is:" + num1 + ", and the 2nd number is:" + num2); 

            }
            static void Raising()
            {
                Console.Writeline("Input Base Number:");
                
                int base = Console.Readline();

                Console.Writeline("Input the Exponent:");

                int exponent = Console.WriteLine();

                double power = Math.Pow(base, exponent);

                Console.Writeline("So, the number 3^2=" power)
            }
            static void Fibonacci()
            {
                Console.Writeline("Input number of Fibonacci Series:");

                int i = Console.Readline();

                int i = 0, b = 1, c = 0;
                Console.Write("{0} {1}", a,b);
                for (int i = 2, i < len; i++)
                {
                    c = a + b; 
                    Console.Write(" {0}", c);
                    a = b;
                    b = c;
                }
            }
            static void Prime()
            {
                Console.WriteLine("Input a number:");

                int input = Covert.ToInt32(Console.Readline());

                bool IsPrime = true;

                 for (int i = 2; i < number/2; i++)
                 {
                     if (number % i == 0)
                     {
                        IsPrime = false;
                        break;
                    }
                 }
                    if (IsPrime)
                    {
                        Console.Write("Number is Prime.");
                        }
                        else
                        {
                            Console.Write("Number is not Prime.");
                            }
                            Console.ReadKey();
                            }
            static void digits()
            {
                Console.Writeline("Input Digits:");
                int input = Convert.ToInt32(Console.Readline());
                int sum = 0;
                while(num > 0) 
                {
                    sum +- input % 10;
                    input /= 10;
                }

                Console.Writeline(sum);
                
            }
            static void Main(string[] args)
            {
                SayHello();
                Welcome();
                AddTwoNums();
                Spaces();
                //Array();
                Swap();
                Raising();
                Fibonacci();

            }

        }
    }
}