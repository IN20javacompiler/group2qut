using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group2JavaCompiler.AST
{
    class AssignExpression:Expression
    {
        private Expression lhs, rhs;
        public AssignExpression(Expression lhs,Expression rhs)
        {
            this.lhs = lhs;
            this.rhs = rhs;
        }
    }
}
