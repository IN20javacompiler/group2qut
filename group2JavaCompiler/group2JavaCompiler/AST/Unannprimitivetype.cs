using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group2JavaCompiler.AST
{
    class Unannprimitivetype : Node
    {
    }

    public class Unannprimitivetype : Type
    {
        public override void dump(int indent)
        {
            label(indent, "IntType\n");
        }
    }
}
