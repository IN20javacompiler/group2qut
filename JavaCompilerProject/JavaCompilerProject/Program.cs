using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using JavaCompilerProject.AST;

namespace JavaCompilerProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = new System.IO.FileStream(args[0], System.IO.FileMode.Open);
            javaCompiler.Lexer.Scanner scanner = new javaCompiler.Lexer.Scanner(file);
            //javaCompiler.Lexer.Scanner scanner = new javaCompiler.Lexer.Scanner(System.Console.OpenStandardInput());
            javaCompiler.Parser.Parser parser = new javaCompiler.Parser.Parser(scanner);
            parser.Parse();

            /*
            Statement root = new ExpressionStatement(new AssignExpression(new IdentifierExpression("x"), new IntegerLiteralExpression(42)));
            root.dump(0);
            */

            /*
            new Method("main",
                        new NamedType("void"),
                        new List<??> { new Argument("args", new ArrayType(new NamedType("String")) },
                        new List<Statement> { new Ass.. }
                      );
            */
               
            Class root = new Class("public", "Test",
                            new Method("public static",
                            new NamedType("void"),
                            "main",
                            new Arguments(new ArrayType(new NamedType("String")), "args"),
                            new VariableDeclarationStatement(new NamedType("int"), new IdentifierExpression("x"), new IntegerLiteralExpression(42))
                            )
                         );
            root.dump(0);
        }
    }
}
