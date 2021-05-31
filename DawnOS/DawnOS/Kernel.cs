using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace DawnOS
{
    public class Kernel : Sys.Kernel
    {

        // Just started project basic kernel.
        protected override void BeforeRun()
        {
            Console.WriteLine("DawnOS booted successfully. Type a line of text to get it echoed back.");
        }

        protected override void Run()
        {
            Console.Write("Input: ");
            var input = Console.ReadLine();
            Console.Write("Text typed: ");
            Console.WriteLine(input);
        }
    }
}
