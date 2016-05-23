using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group2JavaCompiler
{
    class ExpressionStatement : Statement
    {
        private Expression expr;

        public ExpressionStatement(Expression expr)
        {
            this.expr = expr;
        }

        public override void dump(int indent)
        {
            label(indent, "ExpressionStatement\n");
            expr.dump(indent + 1);
        }
    }
}
