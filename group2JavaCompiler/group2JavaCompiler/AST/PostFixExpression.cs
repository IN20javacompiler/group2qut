using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group2JavaCompiler.AST
{
    class PostFixExpression : Node
    {
        public override void dump(int indent)
        {
            label(indent, "PostFixExpression\n");
        }
    }
}
