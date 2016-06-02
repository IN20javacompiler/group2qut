using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group2JavaCompiler.AST
{

    public abstract class Type : Node
    {

    }

    public class NamedType : Type
    {
        private string name;

        public NamedType(string name)
        {
            this.name = name;
        }

        public override void dump(int indent)
        {
            label(indent, "Type {0}\n", name);
        }
    };
    public class IntType : Type
    {
        public override void dump(int indent)
        {
            label(indent, "INT\n");
        }
    };


    public class BoolType : Type
    {
        public override void dump(int indent)
        {
            label(indent, "BOOLEAN\n");
        }
    };
    public class ArrayType : Type
    {
        NamedType elementType;

        public ArrayType(NamedType elementType)
        {
            this.elementType = elementType;
        }

        public override void dump(int indent)
        {
            label(indent, "Array\n");
            elementType.dump(indent + 1);
        }
    };
    public class VoidType : Type
    {
             public VoidType()
        {
            
        }

        public override void dump(int indent)
        {
            label(indent, "VOID\n");
        }
    };
}
