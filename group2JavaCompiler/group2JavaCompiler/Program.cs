using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group2JavaCompiler
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = new System.IO.FileStream(args[0], System.IO.FileMode.Open);
            javaCompiler.Lexer.Scanner scanner = new javaCompiler.Lexer.Scanner(file);
            javaCompiler.Parser.Parser parser = new javaCompiler.Parser.Parser(scanner);
            parser.Parse();
        }
    }
}
