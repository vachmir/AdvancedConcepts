using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace AdvancedConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Person("Asdrew", "Smith"));
            people.Add(new Person("Mike", "Greham"));
            people.Add(new Person("George", "W"));
            people.Add(new Person("David", "Peters"));

            Console.WriteLine($"{people[2].Name} {people[2].Surname}");
            people[2].Surname = "Woolrey";
            Console.WriteLine($"{people[2].Name} {people[2].Surname}");


            Points point1 = new Points(45, 20);
            Points point2 = new Points(95, 60);
            Points point3 = point1 - point2;
            point2 -= point1;
            Console.WriteLine(point1);
            Console.WriteLine(point2);
            Console.WriteLine(point3);

            point2.Print();
            BuildAnonymousType("A", "Blue", 65);

            static void BuildAnonymousType(string make, string color, int currSp)
            {
               // Build anonymous type using incoming args.
                var car = new { Make = make, Color = color, Speed = currSp };
               // Note you can now use this type to get the property data!
               Console.WriteLine($"{car.Color}, {car.Make}, {car.Speed}");
            }
            static unsafe void SquareIntPointer(int* myIntPointer)
            {
               // Square the value just for a test.

               *myIntPointer += *myIntPointer;
            }
            unsafe
            {
                int[] array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                int[] array2 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                int[] array3 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                var gch = GCHandle.Alloc(array, GCHandleType.Pinned);
                var gch2 = GCHandle.Alloc(array2, GCHandleType.Pinned);
                var gch3 = GCHandle.Alloc(array3, GCHandleType.Pinned);

                IntPtr address = gch.AddrOfPinnedObject();
                IntPtr address2 = gch2.AddrOfPinnedObject();
                IntPtr address3 = gch3.AddrOfPinnedObject();

                gch.Free();
                gch2.Free();
                gch3.Free();
                Console.WriteLine($"1st array address {address.ToString()}");
                Console.WriteLine($"2nd array address {address2.ToString()}");
                Console.WriteLine($"3rd array address {address3.ToString()}");

                double myDouble = 123.45;
                double* ptrToMyDouble = &myDouble;

                Console.WriteLine($"Value of myDouble is {myDouble}");
                Console.WriteLine($"Address of myDouble is {(int)&myDouble}");

                *ptrToMyDouble = 678.91;
                Console.WriteLine($"Value of myDouble is {*ptrToMyDouble}");
                Console.WriteLine($"Address of myDouble is {(int)&ptrToMyDouble}");

                int addresOfVariable = 11;
                bool* bl;
                Console.WriteLine($"Address is {(int)&addresOfVariable}");
                Console.WriteLine($"Address is {(int)&bl}");
            }

            Console.WriteLine();
            UnsafeStackAlloc();
            static unsafe string UnsafeStackAlloc()
            {
                char* p = stackalloc char[52];
                for (int k = 0; k < 52; k++)
                {
                    p[k] = (char)(k + 65);
                }
                Console.WriteLine("Alloc");
                return new string(p);
            }
        }
    }
    
}
