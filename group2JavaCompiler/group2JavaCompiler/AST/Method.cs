using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group2JavaCompiler
{
    class Method : Node
    {
        string modifier, name;
        Types type;
        VariableDeclarationStatement stmt;
        Arguments arg;

        public Method(string modifier, Types type, string name, Arguments arg, VariableDeclarationStatement stmt)
        {
            this.modifier = modifier;
            this.type = type;
            this.name = name;
            this.arg = arg;
            this.stmt = stmt;
        }

        public override void dump(int indent)
        {
            label(indent, "MethodDeclaration {0}\n", name);
            label(indent + 1, "Modifier {0}\n", modifier);
            type.dump(indent + 1);
            arg.dump(indent + 1);
            label(indent + 1, "MethodBody\n");
            stmt.dump(indent + 1);
        }
    }
}
