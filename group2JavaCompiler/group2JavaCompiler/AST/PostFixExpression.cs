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

    public class IdenExp : Expression
    {
        private string name;

        public IdenExp(string name)
        {
            this.name = name;
        }

        public override void dump(int indent)
        {
            label(indent, "Identifier {0}\n", name);
        }
    };
}
