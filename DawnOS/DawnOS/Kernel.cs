using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using Cosmos.HAL;

namespace DawnOS
{
    public unsafe class Kernel : Sys.Kernel
    {

        private static byte* ProcessMemory;
        private static int ProcessMemorySize;
        public static string CurrentDir = "";
        public static string CurrentVol = "0";
        public static Sys.FileSystem.CosmosVFS fs = new Sys.FileSystem.CosmosVFS();
        public static int BootMode = 0;
        
        
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
