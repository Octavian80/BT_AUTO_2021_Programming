using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming
{
    class Person
    {
        string name;
        char sex;
        string[] nationality;
        bool isHungry;
        DateTime dob;

        void Eat()
        {
            Console.WriteLine("The person is eating...");
            isHungry = false;


        }
        void Running()
            {
            Console.WriteLine("the persone is running for his health ");
            isHungry = true;
        }

        void SetName (string personName)
        {

            name = personName;
        }

        public void PrintPerson()
        {
            Console.WriteLine("Name of the person is {0}", name);
            Console.WriteLine("->Curent state for hungry is {0}", isHungry);
            
        }
    }
}
