using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using group2JavaCompiler.AST;

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
            /*
           Expression root = new AssignExpression(new IdentifierExpression("x"), new IntegerLiteralExpression(42));*/

            Class root = new Class("test");
           
            Method method = new Method("public static", "void", "main");

            ArrayType arrayType = new ArrayType(typeof(string[]));
            NamedType nameType = new NamedType("args");
            

        }
    }
}
