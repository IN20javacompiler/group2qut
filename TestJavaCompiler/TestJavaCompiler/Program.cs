using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestJavaCompiler
{
    class Program
    {
        static void Main(string[] args)
        {
            var filename = args[0];
            var file = new FileStream(args[0], FileMode.Open);
            Scanner scanner = new Scanner(file);
            Parser parser = new Parser(scanner);
            parser.Parse();
            Parser.root.dump(0);
            var writer = new StreamWriter(filename + ".il");
            writer.WriteLine("﻿.assembly {0} {{}}", filename);
            writer.Close();
        }
    }
}
