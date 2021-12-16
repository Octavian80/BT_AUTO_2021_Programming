using System;

namespace BT_AUTO_2021_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            //Course01(args);
            // Course02(args);
            Course03(args);
        }
        static void  Course01(string[]args)
        {
            const int MAX_SIZE = 100;
            const double PI = 3.141592;
            const int MAX_NUMBER = 5;

            Console.WriteLine("Hello World!");
            Console.WriteLine("Ana are mere");

            int numberOfStudents = 5;
            int count;
            int a, b;
            a = numberOfStudents + 1;
            a = a + numberOfStudents;
            short s = 5;
            ulong ul = 65;

            float numberFloat = 5.6F;
            double numberDouble = 5.6;

            float f = (float)numberDouble;
            int numberInt = (int)f;




            Console.WriteLine(typeof(int).IsPrimitive);

            bool myBoolean = false;

            char ch = 'd'; //'1' != 1;

            string myString = "Ana are mere si pere";
            string result = myString + " si struguri";
            Console.WriteLine(result);

            DateTime dataCurenta = new DateTime(2021, 12, 8);
            Console.WriteLine(dataCurenta);

            Console.WriteLine(numberFloat * a);
            Console.WriteLine(5 / 6.0);
            Console.WriteLine(5 % 6);

            int x = 2;
            x += 5;//x-x+5;
            //x++<=>x=x+1
            //++x <=>x=x+1
            Console.WriteLine(++x);
            Console.WriteLine(!(x == a));

            int number = 8;
            Console.WriteLine("Number tested is" + number);

            if (number >= 0)
            {
                Console.WriteLine("Number is positive!");

            }

            else
            {
                Console.WriteLine("Number is negative");
            }

            if (number % 2 == 0)
            {
                Console.WriteLine("Even number!");
            }
            else
            {
                Console.WriteLine("Odd number!");
            }

            if (number <= 40 && number >= 0)
            {
                if (number <= 20)
                {
                    Console.WriteLine("Student failed!");
                }

                else
                {
                    Console.WriteLine("Student passed!");
                }
            }
            else
            {
                Console.WriteLine("Grade is invalid!");
            }

            //One line if/else
            String message = (number % 2 == 0) ? "Even" : "Odd";
            Console.WriteLine(message);

            if (number == 1)
            {
                Console.WriteLine("Monday");
            }
            if (number == 2)
            {
                Console.WriteLine("Tuesday");
            }
            if (number == 3)
            {
                Console.WriteLine("Wednesday");
            }
            if (number == 5)
            {
                Console.WriteLine("Thursday");

            }
            if (number == 5)
            {
                Console.WriteLine("Friday");
            }
            if (number == 6)
            {
                Console.WriteLine("Saturday");
            }
            if (number == 7)
            {
                Console.WriteLine("Sunday");
            }
            if (number < 1 || number > 7)
            {
                Console.WriteLine("Sorry not a valid day!");
            }

            switch (number)
            {
                case 1:
                    {
                        Console.WriteLine("Monday");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Tuesday");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Wednesday");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Thursday");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Friday");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Saturday");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Sunday");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Not a valid day!");
                        break;
                    }
            }

            int counter = 0;
            while (counter <= MAX_NUMBER)
            {
                Console.WriteLine("Current number is:" + counter);
                counter++;
            }

            counter = 0;
            do
            {
                Console.WriteLine("Current number is:" + counter);
                counter++;
            }
            while (counter <= 5);

            for (counter = 0; counter <= MAX_NUMBER; counter++)
            {
                //Console.WriteLine("Current number is:" + counter);
                Console.WriteLine("Current number is {0}", counter);
            }

            foreach (string argument in args)
            {
                Console.WriteLine("The argument is: {0}", argument);
            }

            for (counter = 0; counter < args.Length; counter++)
            {
                Console.WriteLine("The argument is:{0}", args[counter]);
            }

            int year = 1900;
            int febDays = 28;

            if (year % 4 == 0)
            {
                if (year % 100 == 0 && year % 400 != 0)
                {
                    febDays = 29;
                }

                if (year % 100 != 0)
                {
                    febDays = 29;
                }


            }

            Console.WriteLine("February has {0} days", febDays);

            ///calculator
            if (args[0].Length == 3)
            {

                string arg = args[0];
                float n1 = float.Parse(arg[0].ToString());
                float n2 = float.Parse(arg[2].ToString());
                string op = arg[1].ToString();
                // implement calculator logic here
                switch (op)
                {
                    case "+":
                        {
                            float rez = n1 + n2;
                            Console.WriteLine("Suma este: " + rez);
                            break;
                        }


                    case "-":
                        {
                            float rez = n1 - n2;
                            Console.WriteLine("Diferenta este: " + rez);
                            break;
                        }


                    case "*":
                        {
                            float rez = n1 * n2;
                            Console.WriteLine("Inmultirea este: " + rez);
                            break;
                        }

                    case "/":
                        {
                            float rez = n1 / n2;
                            Console.WriteLine("Impartirea este: " + rez);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Not a valid sign!");
                            break;
                        }

                }




            }
            else
            {
                Console.WriteLine("3 args are needed!");
            }


            ///calculator
            int suma = 0;
            for (int i = 1; i <= 100; i++)
            {
                suma = suma + i;
            }
            Console.WriteLine("Suma primelor 100 numere este: " + suma);

            int numar = 45833854;
            string numars = numar.ToString();
            string numarinv = "";

            for (int i = numars.Length - 1; i >= 0; i--)
                numarinv = numarinv + numars[i].ToString();


            Console.WriteLine("numar: " + numars);
            Console.WriteLine("numar inv: " + numarinv);

            if (numars == numarinv)
                Console.WriteLine("Este palindrom ");
            else
                Console.WriteLine("NU este palindrom ");


            int numarmax = 30;
            for (int i = 1; i <= numarmax; i++)
            {
                bool esteprim = true;
                for (int j = 2; j < i; j++)
                    if (i % j == 0) esteprim = false;

                if (esteprim)
                    Console.WriteLine("numarul este prim " + i);
            }

            //// exercitii///

            int q = 0;
            int numarulmax = 7;
            int sumalor = 0;

            for (q = 1; q <= numarulmax; q++)
            {
                Console.WriteLine("Numarul este :" + q);
                sumalor = sumalor + q;
            }
            Console.WriteLine("Suma numelor este :" + sumalor);

            int numero = 59;
            int r;
            int sum = 0; 
            int t;

            for (t=numero; numero != 0; numero = numero / 10) 
            {
                r = numero % 10;
                sum = sum*10 + r;
            }
            if(t==sum)
            {
                Console.WriteLine("Is a palindrome number" + t);
            }
            else
            {
                Console.WriteLine("Is not a palindrome number" + t);
            }

        }

         static void Course02(string[]args)
        {
            Circle c1 = new Circle();
            Circle c2;// c2 will be null!!!
            c1.SetRadius(10);
            /* double area = c1.GetArea();*/
            /* Console.WriteLine(c1.GetArea());*/
            c1.PrintCircle();
            Circle c3 = new Circle();
            c3.SetRadius(5);
            /*Console.WriteLine(c3.GetArea());*/
            c3.PrintCircle();
            foreach(string Z in args)
            {
                Circle c = new Circle();
                c.SetRadius(Double.Parse(Z));
                Square s = new Square();
                s.SetSide(Double.Parse(Z));
                Rectangle r = new Rectangle();
                r.SetSize(Double.Parse(Z), Double.Parse(Z));
                c.PrintCircle();
                s.PrintSquare();
                r.PrintRectangle();
            }
            Person p1 = new Person();
            p1.SetName("Alex");
            p1.Setsex('m');
            p1.Eat();
            p1.Run();
            p1.Eat();
            p1.PrintPerson();

            Rectangle r1 = new Rectangle();
            r1.SetSize(2, 3);
            r1.PrintRectangle();


        }

        static void Course03(string[]args)
        {
            //ComputeConversion(args);
            CurrencyCalcutor(156, "USD", 4.3734);
            Shape s = GetShape(12, 34, 12.4, 'a', "172d");
            // Console.WriteLine(ConcatenateStrings(args));
            Random rnd = new Random();
            GuessNumber(rnd. Next(1, 1000));
        }

        static bool IsoddNumber(int number)
        {
            return number % 2 != 0;
        }

        static int TestValue(int testVal, int target)
        {
            
            
            if (testVal < target)
            {
                Console.WriteLine("Number to be guess is higher !");
                return -1;
            }
            if (testVal > target)
            {
                Console.WriteLine("Number to be guess is lower !");
                return 1;
            }
            Console.WriteLine("This is number ");
            return 0;
        }

        static void GuessNumber(int n)
        {
            int currentNumber = 0;
            do
            {
                currentNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Number chosen is {0}", currentNumber);
            }
            while (TestValue(currentNumber,n)!=0);

            
        }
        static Shape GetShape(int x, int y, double a, char t , String s)
        {
            Console.WriteLine(x);
            return new Shape();
        }

        static string ConcatenateStrings(string[]args)
        {
            string returnString = "";
            foreach(string s in args)
            {
                returnString += s;//returnString=returnString+s
            }
            return returnString;
        }

        static void ComputeConversion(string[]args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("The application receives only 3 parameters: amount , currency, exchange rate");
            }
            else
            {
                Console.WriteLine("{0}{1}{2}", args[0], args[1], args[2]);

                CurrencyCalcutor(Double.Parse(args[0]), args[1], Double.Parse(args[2]));
            }

        }
        
        static void CurrencyCalcutor (double amount , String currency,double conversionRate )
        {
            Console.WriteLine("By converting {0}{1} into RON we obtain {2}RON", amount, currency, amount * conversionRate);
        }

        
        

        
    }
}
