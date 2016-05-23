using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group2JavaCompiler.AST
{
    class IfThenElseStatement : Statement
    {
        private Expression cond;
        private Statement thenStmt, elseStmt;

        public IfThenElseStatement(Expression cond, Statement thenStmt, Statement elseStmt)
        {
            this.cond = cond;
            this.thenStmt = thenStmt;
            this.elseStmt = elseStmt;
        }

        public override void dump(int indent)
        {
            label(indent, "IfThenElseStatement\n");
            cond.dump(indent + 1, "cond");
            thenStmt.dump(indent + 1, "then");
            elseStmt.dump(indent + 1, "else");
        }
    }
}
