using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group2JavaCompileU.AST
{

    class unapr : Node
    {
        public class Integerprimitivetype : Type
        {
            public override void dump(int indent)
            {
                label(indent, "Integer\n");
            }
        }
    }
}
