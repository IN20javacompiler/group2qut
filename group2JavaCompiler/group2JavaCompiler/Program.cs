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
            javaCompiler.Lexer.Scanner scanner = new javaCompiler.Lexer.Scanner(System.Console.OpenStandardInput());
            javaCompiler.Parser.Parser parser = new javaCompiler.Parser.Parser(scanner);
            parser.Parse();
        }
    }
}
