using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaCompilerProject.AST
{
    class IdentifierExpression : Expression
    {
        private string name;

        public IdentifierExpression(string name)
        {
            this.name = name;
        }

        public override void dump(int indent)
        {
            label(indent, "IdentifierExpression {0}\n", name);
        }
    }
}
