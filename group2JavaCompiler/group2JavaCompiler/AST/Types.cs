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

    class NamedType : Types
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

    class ArrayType : Types
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
