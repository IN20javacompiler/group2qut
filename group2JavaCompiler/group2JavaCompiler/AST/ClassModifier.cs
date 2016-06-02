using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group2JavaCompiler.AST
{
    class ClassModifier : Node
    {
        public ClassModifier()
        {
        }

        public override void dump(int indent)
        {
            label(indent, "Class Modifier\n");
        }
    }
}
