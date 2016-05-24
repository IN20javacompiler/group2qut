
namespace group2JavaCompiler.AST
{
    public class Arguments : Expression
    {
        private string name;
        private ArrayType type;

        public Arguments(ArrayType type, string name)
        {
            this.type = type;
            this.name = name;
        }

        public override void dump(int indent)
        {
            label(indent, "Arguments :{0}", name);
            type.dump(indent);
        }
    }
}
