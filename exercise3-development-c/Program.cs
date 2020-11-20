using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text.RegularExpressions;

namespace exercise3_development_c
{
    class Program
    {
        public class A
        {
            public void CompareStrings(string test1, string test2)
            {
                int result = string.Compare(test1, test2, StringComparison.Ordinal);
                if (result == 0)
                    Console.WriteLine("1. The strings are the same");
                else
                    Console.WriteLine("1. The strings are different");
            }

            public void CompareSize()
            {
                var listOne = new List<int> { 1, 2, 3, 4, 5 };
                var listTwo = new List<int> { 1, 2, 3, 4, 5, 7 };

                if (listOne.SequenceEqual(listTwo))
                {
                    Console.WriteLine("2. Equal list");
                }
                else
                {
                    Console.WriteLine("2. Not Equal list");
                }

                Console.WriteLine("Count of list one " + listOne.Count);
                Console.WriteLine("Count of list two " + listTwo.Count);
            }

            public void RemoveDuplicateNumbers()
            {
            
                List<int> listNumbers = new List<int>();
                listNumbers.Add(1);
                listNumbers.Add(1);
                listNumbers.Add(2);
                listNumbers.Add(3);
                listNumbers.Add(4);
                listNumbers.Add(4);
                listNumbers.Add(5);
                listNumbers.Add(6);
                listNumbers.Add(7);
                listNumbers.Add(8);
                listNumbers.Add(10);

                List<int> distinct = listNumbers.Distinct().ToList();

                foreach (int value in distinct)
                {
                    Console.WriteLine("{0}", value);
                    Console.ReadKey();
                }
            }             
        }

        class B : A , Interface1
        {
            public string newResult = "Test uno";

            void Interface1.Body()
            {
            }

            void Interface1.Parameters()
            {
            }

            void Interface1.Functionality()
            {
                Console.WriteLine("Hello Interface");
            }
        }





        static void Main(string[] args)
        {
            //compare string
            Console.WriteLine("###---------------> compare string");
            string test1 = "Test uno";
            string test2 = "Test doss";
            A compareResult = new A();
            compareResult.CompareStrings(test1, test2);
            Console.ReadKey();


            //size list
            Console.WriteLine("###---------------> Size list");
            A checkList = new A();
            checkList.CompareSize();
            Console.ReadKey();

            //method B
            Console.WriteLine("###---------------> method B");
            string test3 = "Test uno";
            B newResult = new B();
            newResult.CompareStrings(test1, test3);
            Console.ReadKey();

            //create an interface
            Console.WriteLine("###---------------> create an interface");
            Interface1 testInterface = new B();
            testInterface.Functionality();
            Console.ReadKey();

            //List of values (orders by desc and asc order)
            Console.WriteLine("###---------------> List of values Descending");
            List<string> valueLists = new List<string>() { "Text", "Computer", "Automation", "Visual Studio", "Auto Parts", " "," " };
            List<string> sortedValueListsDesc = valueLists.OrderByDescending(list => list).ToList();
            foreach (string value in sortedValueListsDesc)
            {
                Console.WriteLine(value);
                Console.ReadKey();
            }
            Console.WriteLine("###---------------> List of values Ascending");
            sortedValueListsDesc.Reverse();
            foreach (string value in sortedValueListsDesc)
            {
                Console.WriteLine(value);
                Console.ReadKey();
            }

            //filters the above list, not selecting white spaces (" ").
            Console.WriteLine("###---------------> filters the above list, not selecting white spaces");

            List<string> noSpaces = valueLists.Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
            foreach (string value in noSpaces)
            {
                Console.WriteLine(value);
                Console.ReadKey();
            }

            //Create a method that removes duplicate numbers
            Console.WriteLine("###---------------> List without duplicate numbers");
            A Duplicate = new A();
            Duplicate.RemoveDuplicateNumbers();
            Console.ReadKey();
        }
    }
}
