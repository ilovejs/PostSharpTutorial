using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS1
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));

            SayHello();
            SayGoodBye();

            Console.WriteLine("----------------------------------------");

            SayHello2();
            SayGoodBye2(); 
        }

        [Trace2("MyCategory")]
        private static void SayHello2()
        {
            Console.WriteLine("Hello, world.");
        }

        [Trace2("MyCategory")]
        private static void SayGoodBye2()
        {
            Console.WriteLine("Good bye, world.");
        }

        [Trace("MyCategory")]
        private static void SayHello()
        {
            Console.WriteLine("Hello, world.");
        }

        [Trace("MyCategory")]
        private static void SayGoodBye()
        {
            Console.WriteLine("Good bye, world.");
        } 
    }
}
