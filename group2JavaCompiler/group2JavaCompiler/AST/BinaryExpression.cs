using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group2JavaCompiler.AST
{
    class BinaryExpression : Expression
    {
        private char op;
        private Expression lhs, rhs;

        public BinaryExpression(Expression lhs, char op, Expression rhs)
        {
            this.op = op;
            this.lhs = lhs;
            this.rhs = rhs;
        }

        public override void dump(int indent)
        {
            label(indent, "BinaryExpression {0}\n", op);
            lhs.dump(indent + 1, "lhs");
            rhs.dump(indent + 1, "rhs");
        }
    }
}
