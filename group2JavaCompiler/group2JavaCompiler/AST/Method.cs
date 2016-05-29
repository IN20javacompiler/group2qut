
namespace group2JavaCompiler.AST
{
    class Method : Node
    {
        Modifier modifier1, modifier2;  // public  &&  static
        string name;
        Type type;
        VariableDeclarationStatement stmt;
        Arguments arg;

        public Method(Modifier modifier1, Modifier modifier2, Type type, string name, Arguments arg, VariableDeclarationStatement stmt)
        {
            this.modifier1 = modifier1;
            this.modifier2 = modifier2;
            this.type = type;
            this.name = name;
            this.arg = arg;
            this.stmt = stmt;
        }

        public override void dump(int indent)
        {
            modifier1.dump(indent + 1);
            modifier2.dump(indent + 1);
            label(indent + 1, "MethodDeclaration {0}\n", name);
            type.dump(indent + 1);
            arg.dump(indent + 1);
            label(indent + 1, "MethodBody\n");
            stmt.dump(indent + 1);
        }
    }
}