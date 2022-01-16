using System;
using System.Collections.Generic;

namespace BT_AUTO_2021_Programming
{
    class Program

    {
        public enum Browsers
        {
            Chorme, 
            Firefox,
            Edge
        }
        static void Main(string[] args)
        {
            //Exercises (args);
            //Course01(args);
            // Course02(args);
            // Course03(args);
            //Course04();
            // Course05();
            //Course06();
            // Course07();
            // Course08();
            //Course09(args);
              Homework();
            

        }

        private static void Homework()
        {

            Room room1 = new Room();
            Floor floor1 = new Floor(2, 1, 1, 1, room1);
            DepositSpace depositSpace1 = new DepositSpace(12, 2, 1, 0, 5);
            Kitchen kitchen1 = new Kitchen(25, 1, 2, 1, 1,1);
            MeetingRoom meetingRoom1 = new MeetingRoom(20, 6, 3, 5, 1,2,5);
            WorkingSpace workingSpace1 = new WorkingSpace(1, 1, 1, 1, 1,1);
            var room1 = depositSpace1;


            


            List<Room> roomsList1 = new List<Room>();

           
        }

        private static void RecursiveMethod()
        {
            RecursiveMethod();
        }
        private static void Course09(string[] args)
        {
            try
            {
                Console.WriteLine(args[0]);
                int x = int.Parse(args[0]);
                int y = 0;
                int z = 7 / x;
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("Index out of bounds");
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Failed to convert to INT");
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by 0");
            }
            catch (Exception ex)
            {
                Console.WriteLine("There is an exception");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

       
            finally
            {
                Console.WriteLine("The finally block always executes");
            } 
            
            
            //throw new NotImplementedException();
            

            Shape sh=new Shape();
            try
            {
                sh.Draw();
            }
            finally
            {
                sh.Dispose();
                
            }
            //this is equivalent to try finally
            using (Shape s2 =new Shape())
            {
                s2.Draw();
            }

            

            


        }

        private static void Course06()
        {
            Car c1 = new Car(true, 20, 90);
            Car c2 = new Car(false, 0, -90);
            c1.Start();
            c1.Accelerate();
            c1.TurnLeft();
            c1.TurnRight();

            Console.WriteLine(Car.ConvertHpToKw(150));

            Rectangle r1 = new Rectangle(3, 4);
            r1.PrintRectangle();
            
            r1.SetLenght(10);
            r1.PrintRectangle();

            c2.Start();
            c2.GerUp();
            c2.Accelerate(20);
            c2.Steer(20);
            c2.Accelerate(10);
            c2.GerUp();
            c2.Accelerate();
            c2.PrintCar();

            c2.CarBrand = "Name";

        }

        static void Exercises(string[] args)
        {


            /*  Console.Write("Enter a number:");
              double num1 = Convert.ToDouble(Console.ReadLine());

              Console.Write("Enter a operator:");
              string op = Console.ReadLine();


              Console.Write("Enter a number:");
              double num2 = Convert.ToDouble(Console.ReadLine());

              if (op == "+")
              {
                  Console.WriteLine(num1 + num2);
              }
              else if (op == "-")
              {
                  Console.WriteLine(num1 - num2);
              }
              else if (op == "/")
              {
                  Console.WriteLine(num1 / num2);
              }
              else if (op == "*")
              {
                  Console.WriteLine(num1 * num2);
              }

              else
              {
                  Console.WriteLine("Invalid operator");
              }
              */


            /*  int index = 1;
              while (index <= 5)
              {
                  Console.WriteLine(index);
                  index++;
              } */

            /*
            int x = 14;
            int y = 15;
            
            if (x==y)
            {
                Console.WriteLine("Numere sunt egale");
            }
            else
            {
                Console.WriteLine("Numere nu sunt egale");
            } */


            /*  int x=5;
              int y=x % 2;

              if (y == 0)
              {
                  Console.WriteLine("Numar este impar");
              }
              else
              {
                  Console.WriteLine("Numarul este par");
              } */


            /* int x = 15;

               if (x>=0)
                {
                    Console.WriteLine("Numar este pozitiv ");
                }
                else
                {
                    Console.WriteLine("Numarul este negativ");
                } */


            /*  int x = 51;
              int y = 25;
              int z = 10;

              if (x>y  && x>z)
              {
                  Console.WriteLine("Numarul cel mai mare este: " + x);
              }
              if (x<y && y>z)
              {
                  Console.WriteLine("Numarul cel mai mai mare este" + y);
              }
              if(z>x && z>y)
              {
                  Console.WriteLine("Numarul cel mai mare este" + z);
              }*/

            /*Volume volume = new Volume();
            volume.GetVolume(2);

            Console.WriteLine(volume.GetVolume(2));*/


            Author author1 = new Author("Oros Octavoian", "oti@yahoo.com");
            Author author2 = new Author("Oros Octavoian", "oti@yahoo.com");
            Book book1 = new Book("Povesti Nemuritoare", 1980, 20, author1); 

            
        

            Console.WriteLine("Book: "+book1.GetName() + "(" +book1.GetPrice()+ " RON)" + ", by " + book1.GetAuthor() +", publihed in "+book1.GetYear());

            

            

            


            
           
            









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

        static void Course04()
        {
            DrawFullShape(5, 3);
            Console.WriteLine();
            DrawFullShape2(5, 3);
            Console.WriteLine();
            DrawShapeOutline(5, 3);
            Console.WriteLine();
            DrawFullCorners(10, 12);

            Circle c1 = new Circle();// instantiate c1 with defaul (no params)constructor
            Circle c2 = new Circle(10) ;
            c1.PrintCircle();
            c2.PrintCircle();

            Person p1 = new Person();
            Person p2 = new Person("Alex", 'm',new string[]{"Romanian"}, false, new DateTime());
            p1.PrintPerson();
            p2.PrintPerson();

            Rectangle r1 = new Rectangle(2, 7);
            r1.PrintRectangle();

            Square s1 = new Square(6);
            s1.PrintSquare();

            StructExamples se = new StructExamples() ;
            StructExamples.MyStruct myStruct = new StructExamples.MyStruct();
            myStruct.Assign(10, "abc");
            Console.WriteLine(myStruct.ComputeSum());

            StructExamples.Rectangle r2 = new StructExamples.Rectangle();
            r2.Assign(2, 5, 7);
            Console.WriteLine(r2.GetVolume());
        }

        static void Course05()
        {
            DrawShapeOutline(5);
            DrawShapeOutline(10,5);
            DrawFullShape(7);

            Circle c = new Circle(4);
            c.Draw();
            Triangle t1 = new Triangle(5,7,9);
            t1.Draw();
            Square s1 = new Square(5);
            Rectangle r1 = new Rectangle(2,7);
            Console.WriteLine(s1.GetArea());
            Console.WriteLine(r1.GetArea());
            Console.WriteLine(c.ToString());
            Console.WriteLine(t1.ToString());
            Console.WriteLine(r1.ToString());
            Console.WriteLine(s1.ToString());

            Teacher teacher1 = new Teacher("Programming","UPB",2000,"Gigel Programatoru",'m');
            teacher1.PrintTeacher();

            Student student1 = new Student("AN1", true,true,"Andreea A", 'f');
            student1.PrintStudent();


        }

        private static void Course07()
        {
            Square s1 = new Square();
            Rectangle r1 = new Rectangle();
            Shape sh1 = new Shape();

            //polymorhism

            IShape s2 = new Square();
            IShape r2 = new Rectangle();
            IShape sh2 = new Shape();

            List < string >lista = new List<string>();
            List<IShape> shapeList = new List<IShape>();
            shapeList.Add(s2);
            shapeList.Add(r2);
            shapeList.Add(sh2);
            shapeList.Add(s1);

            s1.Draw();
            s2.Draw();
            s2.State();
            ((AbstractShape)s2).DoSomething();

            s1.PrintSquare();
            ((Square)s2).PrintSquare();


            // example fo using polymorphism
            Shape sh3;
            string type = "rectangle";

            switch (type)
            {
                case "square":
                    {
                        sh3 = new Square();
                        break;

                     }

                case "rectangle":
                    {
                        sh3 = new Rectangle();
                        break;
                    }
                default:
                    {
                        sh3 = new Shape();
                        break;
                    }


            }
            sh3.Draw();

            PartialClass pc = new PartialClass();
            pc.Method1();
            pc.Method2();


        }


        private static void Course08()
        {
            Person p = new Person("Ionel", "Ionescu", "Str. Margelelor nr.2", "Vartop", "RO");
            Employee e = new Employee("Makaducu", "Makao", "-", "Anarivo", "Magadascar", 1500);
            PartTimeEmployee pe = new PartTimeEmployee("Andrei", "Antonescu", "Str.Unirii nr.2", "Iasi", "RO", 1000);

            Person.PrintPersonStatic(p);
            Employee.PrintPersonStatic(e);
            Employee.PrintPersonStatic(pe);

            p.PrintPerson();

            int[] intArray = new int[5] { 1, 2, 3, 4, 5 };

            Shape s1 = new Shape();
            Rectangle r1 = new Rectangle();
            Shape[] shapes = new Shape[2]{ s1, r1 };

            foreach(int x in intArray)
            {
                Console.WriteLine(x);
            }
            for(int i=0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }

            List<string> myList = new List<string>();
            myList.Add("Alex");
            myList.Add("Andreea");
            myList.Add("Andrei");

            Console.WriteLine(myList.IndexOf("Alex"));
            Console.WriteLine(myList[0]);

            foreach(string s in myList)
            {
                Console.WriteLine(s);
            }

            for (int i=0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }

            String stringDemo = "ana are mere";
            Dictionary<char, int> characterFreq = new Dictionary<char, int>();
            foreach(char c in stringDemo)
            {
               if( characterFreq.ContainsKey(c))
                {
                    characterFreq[c] = characterFreq[c] + 1;
                }
                else
                {
                    characterFreq.Add(c, 1);
                }

               foreach(char key in characterFreq.Keys)
                {
                    Console.WriteLine("{0}:{1}", key, characterFreq[key]);
                }
               foreach(KeyValuePair<char, int>kvp in characterFreq)
                {
                    Console.WriteLine("{0}:{1}", kvp.Key, kvp.Value);
                }

               // SortedList<int, string> listSorted = new SortedList<int, string>();
                var listSorted = new SortedList<int, string>();
                listSorted.Add(6, "abc");
                listSorted.Add(10, "abcd");
                listSorted.Add(1, "xyz");

                foreach(int key in listSorted.Keys)
                {
                    Console.WriteLine("{0}:{1}", key, listSorted[key]);
                }

               // HashSet<int> hs = new HashSet<int>(intArray);
                var hs = new HashSet<int>(intArray);
                hs.Add(1);
                foreach (int i in hs)
                {
                    Console.WriteLine(i);
                }

                var myQueue = new Queue<int>();
                myQueue.Enqueue(2);
                myQueue.Enqueue(3);
                myQueue.Enqueue(100);
                myQueue.Enqueue(1);

                int value = myQueue.Dequeue();
                Console.WriteLine("Queue elements:{0}", myQueue.Count);

                var myStack = new Stack<int>();
                myStack.Push(2);
                myStack.Push(3);
                myStack.Push(100);
                myStack.Push(1);
                int stackVal = myStack.Pop();
                Console.WriteLine("My stack :{0}", myStack.Count);

                Console.WriteLine(Browsers.Firefox);
            }
        }
        public static void DrawShapeOutline(int width , int height)
        {
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++) // this will print a single line with "*" counting width
                {
                    if (j == 0|| j==height-1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                      if(i==0 || i == width-1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();

            }

        }

        public static void DrawShapeOutline(int l)
        {
            DrawShapeOutline(l, l);
        }


        public static void DrawFullCorners(int width, int height)
        {
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++) // this will print a single line with "*" counting width
                 
                {
                   // if ((j == 0 && i == 0) || (j == 0 && i == width - 1) || (j == height - 1 && i == 0) || (j == height - 1 && i == width - 1))
                    if (j==0|| j==height-1)
                    {
                        if (i == 0 || i == width - 1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();

            }
        }

        

        public static void DrawFullShape (int width, int height)
        {
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++) // this will print a single line with "*" counting width
                {
                    Console.Write("*");
                }
                Console.WriteLine();
              
            }
        }

        public static void DrawFullShape(int l)
        {
            DrawFullShape(l, l);
        }

        


        public static void DrawFullShape2(int width, int height)
        {
            String s = "";
            for (int i = 0; i < width; i++)
            {
                s += "*";
            }   
            for (int j = 0; j < height; j++) // this will print a single line with "*" counting width
                {
                Console.WriteLine(s); 
                }
                

            
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
