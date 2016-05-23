using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group2JavaCompiler
{
    class CompoundStatement : Statement
    {
        private List<Statement> stmts;

        public CompoundStatement(List<Statement> stmts)
        {
            this.stmts = stmts;
        }

        public override void dump(int indent)
        {
            label(indent, "CompoundStatement\n");
            foreach (var child in stmts)
                child.dump(indent + 1);
        }
    }
}
