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
using System.IO;
// must import namespace
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

            string sampleSentence = "According to Strava, athletes with the Metro/heatmap opt-out privacy setting have all data excluded from the mapping project.";
            const int sampleLength = 30;
            var summary = Summarize.Summarizer(sampleSentence, sampleLength);
            Console.WriteLine(summary);

            var newFilePath = "c:\\users\\mike\\desktop\\test_file.copy.rtf";
            if (!File.Exists(newFilePath))
            {
                File.Copy("c:\\users\\mike\\desktop\\test_file.rtf", newFilePath, false);
                var fileText = File.ReadAllText(newFilePath);
                Console.WriteLine(fileText);
            }
            File.Delete(@"c:\users\mike\desktop\health.copy.rtf");

            var test2Path = @"c:\users\mike\desktop\test2_file.txt";
            var fileInfo = new FileInfo(test2Path);
            if (!fileInfo.Exists)
            {
                fileInfo.Create();
            }
            if (!fileInfo.Exists)
            {
                fileInfo.Delete();
            }

            Directory.CreateDirectory(@"c:\users\mike\desktop\test_dir");
            var directs = Directory.GetDirectories(@"c:\users\mike\desktop\projects-2017");
            foreach (var dir in directs)
                Console.WriteLine(dir);
            var dirRoots = Directory.GetDirectoryRoot(@"c:\users\mike\desktop\projects-2017");
            Console.WriteLine("dirROots: " + dirRoots);
            var fileArray = Directory.GetFiles(@"c:\users\mike\desktop\projects-2017", "*.py", SearchOption.AllDirectories);
            foreach (var file in fileArray)
                Console.WriteLine(file);


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