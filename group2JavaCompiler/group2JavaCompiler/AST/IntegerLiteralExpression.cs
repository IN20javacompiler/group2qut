using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group2JavaCompiler.AST
{
    class IntegerLiteralExpression : Expression
    {
        private int value;

        public IntegerLiteralExpression(int value)
        {
            this.value = value;
        }

        public override void dump(int indent)
        {
            label(indent, "IntegerLiteralExpression {0}\n", value);
        }
    }
}
