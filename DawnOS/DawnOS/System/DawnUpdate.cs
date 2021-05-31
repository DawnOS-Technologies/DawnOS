using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DawnOS.System
{
    class DawnUpdate
    {
        public static void InstallBundle(string filename)
        {
            Directory.CreateDirectory(@"0:\system\updatetemp");
            Tar.ExtractTar(filename, @"0:\system\updatetemp");
            foreach (var upd in Directory.GetFiles(@"0:\system\updatetemp"))
            {
                Install(upd);
            }
        }
        public static void Install(string filename)
        {
            Tar.ExtractTar(filename, @"0:\");
        }
    }
}
