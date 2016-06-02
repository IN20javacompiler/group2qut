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

            public override void dump(int indent)
        {
            label(indent, "UnannReferenceType\n");
        }
    }
}
