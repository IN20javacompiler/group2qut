
namespace group2JavaCompiler.AST
{
    class Modifier : Node
    {
        private string name;

        public Modifier(string name)
        {
            this.name = name;
        }

        public override void dump(int indent)
        {
            label(indent, "Modifier {0}\n", name);
        }
    }
}
