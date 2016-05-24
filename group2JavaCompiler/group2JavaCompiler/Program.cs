using System.IO;
namespace group2JavaCompiler
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
            /*  var file = new System.IO.FileStream(args[0], System.IO.FileMode.Open);
             javaCompilerScanner scanner = new Scanner(file);
              //javaCompiler.Lexer.Scanner scanner = new javaCompiler.Lexer.Scanner(System.Console.OpenStandardInput());
              Parser parser = new Parser(scanner);
              parser.Parse();*/

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

            /* Class root = new Class("public", "Test",
                             new Method("public static",
                             new NamedType("void"),
                             "main",
                             new Arguments(new ArrayType(new NamedType("String")), "args"),
                             new VariableDeclarationStatement(new NamedType("double"), new IdentifierExpression("x"), new IntegerLiteralExpression(42))
                             )
                          );
             root.dump(0);*/
        }
    }
}
