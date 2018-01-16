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
            Person mikey = new Person();
            mikey.FirstName = "MIKEY";
            mikey.LastName = "TERWILLAGER";
            mikey.Introduce();
            
            MessageMaker mess = new MessageMaker();
            mess.message = "it snowed today!";
            mess.StateMessage();

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
            byte myNumber = 15;
            int yourNumber = myNumber;
            Console.WriteLine(yourNumber);
            int newNumber = 260;
            byte anotherNumber = (byte)newNumber;
            Console.WriteLine(anotherNumber);
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
        }
    }
}