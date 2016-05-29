
namespace group2JavaCompiler.AST
{
    public abstract class Type : Node
    {

    }

    public class IntType : Type
    {
        public override void dump(int indent)
        {
            label(indent, "IntType\n");
        }
    }

    public class BoolType : Type
    {
        public override void dump(int indent)
        {
            label(indent, "BoolType\n");
        }
    }

    class NamedType : Type
    {
        string name;

        public NamedType(string name)
        {
            this.name = name;
        }

        public override void dump(int indent)
        {
            label(indent, "NamedType {0}\n", name);
        }
    }

    class ArrayType : Type
    {
        NamedType elementType;

        public ArrayType(NamedType elementType)
        {
            this.elementType = elementType;
        }

        public override void dump(int indent)
        {
            label(indent, "ArrayType\n");
        }
    }
}
