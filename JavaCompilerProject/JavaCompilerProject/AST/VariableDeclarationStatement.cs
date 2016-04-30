using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaCompilerProject.AST
{
    class VariableDeclarationStatement : Statement
    {
        private Types type;
        private IdentifierExpression name;
        private IntegerLiteralExpression value;

        public VariableDeclarationStatement(Types type, IdentifierExpression name, IntegerLiteralExpression value)
        {
            this.type = type;
            this.name = name;
            this.value = value;
        }

        public override void dump(int indent)
        {
            label(indent + 1, "VariableDeclarationStatement\n");
            type.dump(indent + 2);
            name.dump(indent + 2);
            value.dump(indent + 2);
        }
    }
}
