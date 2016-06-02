using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group2JavaCompiler.AST
{
    class UnannReferenceType : Node
    {
        public UnannReferenceType()
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
                label(indent, "NamedType {0}\n", name);
            }
        }

        public class Array : Type
        {
            NamedType argtype;

            public Array(NamedType argtype)
            {
                this.argtype = argtype;
            }

            public override void dump(int indent)
            {
                label(indent, "Array\n");
            }
        }

            public override void dump(int indent)
        {
            label(indent, "UnannReferenceType\n");
        }
    }
}
