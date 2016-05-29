using System.IO;
using group2JavaCompiler.AST;

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

            /*
            var file = new System.IO.FileStream(args[0], System.IO.FileMode.Open);
            javaCompiler.Lexer.Scanner scanner = new javaCompiler.Lexer.Scanner(file);
            javaCompiler.Parser.Parser parser = new javaCompiler.Parser.Parser(scanner);
            parser.Parse();

            Class root = new Class(new Modifier("public"), "Test",
                            new Method(new Modifier("public"), new Modifier("static"),
                            new NamedType("void"),
                            "main",
                            new Arguments(new ArrayType(new NamedType("String")), "args"),
                            new VariableDeclarationStatement(new NamedType("int"), new IdentifierExpression("x"), new IntegerLiteralExpression(42))
                            )
                         );
            root.dump(0);
            */
        }
    }
}
