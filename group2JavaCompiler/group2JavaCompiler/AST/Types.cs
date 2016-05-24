using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group2JavaCompiler.AST
{
    public abstract class Types : Node
    {

    }

    public class NamedType : Types
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
    };
    public class IntType : Types
    {
        public override void dump(int indent)
        {
            label(indent, "IntType\n");
        }
    };


    public class BoolType : Types
    {
        public override void dump(int indent)
        {
            label(indent, "BoolType\n");
        }
    };
    public class ArrayType : Types
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
    };
}
