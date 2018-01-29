// namespace. Basic utility classes, primitives.
//using System;
// lists/collections
//using System.Collections.Generic;
// work with data
//using System.Linq;
// text and coding
//using System.Text;
// build multi-thread applications
//using System.Threading.Tasks;

// this app will only use System
//namespace HelloWorld
//{
//    class Program
//    {
//        // when app is run, everything inside Main is compiled.
//        static void Main(string[] args)
//        {
//            //Console.Beep();
//            Console.WriteLine("Hello World");
//            //will throw error!
//            //checked
//            //{
//            //    byte number = 255;
//            //    number += 10;
//            //    Console.WriteLine(number);
//            //}
//            byte number = 255;
//            number += 10;
//            Console.WriteLine(number);

//        }
//    }
//}

using System;
using System.Collections.Generic;
// must import class
using HelloWorld.People;
using HelloWorld.Message;

//cw tab tab = Console.WriteLine;

namespace numberFun
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Byte range: {0} {1}", byte.MinValue, byte.MaxValue);
            //Console.WriteLine("Float range: {0} - {1}", float.MinValue, float.MaxValue);
            //const float Pi = 3.14f;
            //Console.WriteLine(Pi);
            //byte b = 1;
            //int i = b;
            //Console.WriteLine(i);
            //float fNum = 3.99999f;
            //int iNum = (int)fNum;
            //Console.WriteLine("{0} {1}", fNum, iNum);
            //Console.WriteLine("Non compatible conversion");
            //Console.WriteLine("Int range: {0} - {1}", int.MinValue, int.MaxValue);
            //string num = "353388";
            //int numConvert = Convert.ToInt32(num);
            //Console.WriteLine(numConvert);
            //int numParse = int.Parse(num);
            //Console.WriteLine(numParse);
            Console.WriteLine("Handling conversion exceptions using try catch: ");
            //eg string to byte:
            //try
            //{
            //    string a = "3232323";
            //    byte b = Convert.ToByte(a);
            //    Console.WriteLine(b);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("The Number is too large to convert to byte");
                
            //}
            //byte myNumber = 15;
            //int yourNumber = myNumber;
            //Console.WriteLine(yourNumber);
            //int newNumber = 260;
            //byte anotherNumber = (byte)newNumber;
            //Console.WriteLine(anotherNumber);
            //Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);

            //Person mikey = new Person();
            //mikey.FirstName = "MIKEY";
            //mikey.LastName = "TERWILLAGER";
            //mikey.Introduce();

            //MessageMaker mess = new MessageMaker();
            //mess.message = "it snowed today!";
            //mess.StateMessage();

            //int[] numbers = new int[5];
            //numbers[0] = 34234;
            //numbers[1] = 3443;
            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);
            //// values initialized with 0
            //Console.WriteLine(numbers[2]);

            //var names = new string[3] { "James", "Peter", "Simon" };
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);

            //bool[] vals = new bool[3];
            //vals[1] = true;
            //Console.WriteLine(vals[0]);
            //Console.WriteLine(vals[1]);
            //Console.WriteLine(vals[2]);

            //'string' is c# keyword that maps to a .net structure
//            string dogName = "Skip";
//            //can also use String class to get exact same result, but must import System.
//            String puppyName = "Skippy";
//            //likewise with other data types
//            int num = 2342;
//            Int32 num2 = 2342;

//            // concatenate a string
//            string firstName = "John";
//            string lastName = "Junior";
//            string fullName = firstName + " " + lastName;
//            Console.WriteLine(fullName);
//            // use format and join methods on strings
//            var formattedName = string.Format("His name was {0} {1}.", firstName, lastName);
//            Console.WriteLine(formattedName);
//            string[] namesList = new string[3] { "bill", "jack", "daniella" };
//            var joinedNames = string.Join(", ", namesList);
//            Console.WriteLine(joinedNames);
//            // use a verbatim string
//            var sentence = @"Here's the deal: if I'm going to pick where we go, then I get to pick up the...     check! 
//            Alright. Fine by me!";
//            Console.WriteLine(sentence);

            //enums
            var method = SeatingMethod.VIP;
            Console.WriteLine((int)method);
            var methodVal = 3;
            Console.WriteLine((SeatingMethod)methodVal);
            // convert enum to string
            var methodStr = methodVal.ToString();
            Console.WriteLine(SeatingMethod.VIP);
            // console.writeLine always calls toString() on any value to a string
            Console.WriteLine(SeatingMethod.VIP.ToString());
            // convert string to enum  (must first parse string)
            //string newMethod = "XVIP";

            Console.WriteLine("DAY ENUMS:");
            // enum is data type, so must explictly cast enum to int or byte, etc.
            byte MonVal = (byte)Days.Mon;
            int ThuVal = (int)Days.Thu;
            // enum converted to string
            string MonStr = Days.Mon.ToString();
            string ThuStr = Days.Thu.ToString();
            //output
            Console.WriteLine("Day # {0} " + "is {1}.", MonVal, MonStr);
            Console.WriteLine("Day # {0} " + "is {1}.", ThuVal, ThuStr);

            Months FirstMon = Months.Jan;
            Console.WriteLine(FirstMon);
            //convert to string
            String FirstMonStr = Months.Jan.ToString();
            Console.WriteLine(FirstMonStr);
            int FirstMonId = (int)Months.Jan;
            Console.WriteLine(FirstMonId);

            // reference and value types
            int a = 5;
            int b = a;
            b++;
            Console.WriteLine("a = {0}, b = {1}", a, b);
            int[] numArr1 = new int[] { 10, 11, 12 };
            int[] numArr2 = numArr1;
            Console.WriteLine(numArr1[0]);
            // changing value changes for all references that point to that memory value
            numArr2[0] = 1;
            Console.WriteLine(numArr1[0]);

            // add incrementer to calculator

            string sentence = "Here is a Long Long Long Long Long Long Long Long Long Long Long Long Long sentence.";
            const int maxLength = 30;

            if (sentence.Length < maxLength)
            {
                Console.WriteLine(sentence);
            }
            else
            {
                Console.WriteLine("The sentence is longer than {0} characters.", maxLength);
                string[] words = sentence.Split(' ');
                // join words in loop into list. Break if longer than maxLength
                var wordsList = new List<string>();
                int totalLength = 0;
                foreach (string word in words)
                {
                    if (totalLength < maxLength)
                    {
                        totalLength += word.Length + 1;
                        wordsList.Add(word);
                    }
                    else
                        break;
                }
                // use .Join method on String .NET class
                //store as new string and display
                string newSentence = System.String.Join(" ", wordsList) + "...";
                Console.WriteLine(newSentence);
            }


            // write a method to display ... if sentence is too long

            // refactor using static method returning a string

            // move to separate class

        }
        public enum SeatingMethod
        {
            Regular = 1,
            Enhanced = 2,
            VIP = 3
        }

        public enum Days : byte
        {
            Sun = 0,
            Mon,
            Tue,
            Wed,
            Thu,
            Fri
        }

        public enum Months 
        { 
            Jan = 0, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec 
        }

    }
}