
namespace group2JavaCompiler.AST
{
    class Class : Node
    {
        Modifier modifier;
        string name;
        Method method;

        public Class(Modifier modifier, string name, Method method)
        {
            this.modifier = modifier;
            this.name = name;
            this.method = method;
        }

        public override void dump(int indent)
        {
            modifier.dump(indent + 1);
            label(indent + 1, "ClassDeclaration {0}\n", name);
            method.dump(indent + 1);
        }
    }
}