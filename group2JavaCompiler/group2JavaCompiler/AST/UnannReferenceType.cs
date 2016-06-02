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

        public override void dump(int indent)
        {
            label(indent, "UnannReferenceType\n");
        }
    }
}
