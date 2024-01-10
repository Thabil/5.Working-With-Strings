using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Working_With_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This will write same line");
            Console.WriteLine("This will \n wrap to nextline");
            Console.WriteLine("This will \" print out the quotation mark.");

            String firstName = "Thabile";
            String lastName = "Latakgomo";
            //concatination 
            Console.WriteLine(firstName + " " + lastName);

            //functions with strings
            Console.WriteLine(lastName.Length); // the length of the first name is 7
            //methods on strings
            Console.WriteLine(firstName.ToUpper());
            //method with a parameter eg the contains(), its case sensitive
            Console.WriteLine(lastName.Contains("Th"));
            //access characters using index
            Console.WriteLine(firstName[0]);
            //indexOf will tell you iff the value is there and at what position
            Console.Write("index of a is ");
            Console.WriteLine(lastName.IndexOf('a'));
            //substring, to grab from an index onwards
            Console.WriteLine(firstName.Substring(1));

            //you can also give index and length ie how many chars ypu want to grab
            
            Console.WriteLine(firstName.Substring(1, 2));  
            Console.Read();





        }
    }
}
