using System;
using System.IO;

namespace Pr2S2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter writer = File.CreateText("C:\\All\\newfile.txt");
            writer.WriteLine("Learning cs is fun)0)");
            writer.WriteLine("I'm done");
            writer.Close();
        }
    }
}
