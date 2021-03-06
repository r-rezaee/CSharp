﻿using System;

namespace structProj
{
    class Program
    {
        public static void Main()
        {
            // Make an array of Teacher
            Teacher[] tichr = new Teacher[3];

            /*
            // This is how to make three instances of Teacher
            tichr[0] = new Teacher("Anders", "Andersson", 53, "Stockholm", "Stockholms län");
            tichr[1] = new Teacher("Christopher", "Johnsson", 38, "Upplands Väsby", "Stockholms län");
            tichr[2] = new Teacher("Nikolas", "Karlsson", 44, "Uppsala ", "Uppsala län");
            */


            // Iterate thorough Teacher array and take user input and save it in array indexes
            for (int i = 0; i < tichr.Length; i++)
            {

                Console.WriteLine("Name: ");
                tichr[i].fnamn = Console.ReadLine();

                Console.WriteLine("Last Name: ");
                tichr[i].lnamn = Console.ReadLine();

                Console.WriteLine("Age: ");
                tichr[i].age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("City: ");
                tichr[i].city = Console.ReadLine();

                Console.WriteLine("State: ");
                tichr[i].state = Console.ReadLine();


                Console.WriteLine(tichr[i].fnamn + " " + tichr[i].lnamn + " " + tichr[i].age + " " + tichr[i].city + " " + tichr[i].state);

            }

            // Calling a Teacher instance outside of loop after taking all user inputs

            Console.WriteLine(tichr[1].fnamn);

        }

        // Defining struct
        public struct Teacher
        {
            public string fnamn;
            public string lnamn;
            public int age;
            public string city;
            public string state;
                
            // Creating custom struct
            public Teacher(string teacherNamn, string teacherLnamn, int teacherAge, string teacherCity, string teacherState)
            {
                this.fnamn = teacherNamn;
                this.lnamn = teacherLnamn;
                this.age = teacherAge;
                this.city = teacherCity;
                this.state = teacherState;

            }

        }
    }
}
