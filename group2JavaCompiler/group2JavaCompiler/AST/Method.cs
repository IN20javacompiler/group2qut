using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group2JavaCompiler.AST
{
    public class Method : Node
    {
        string modifier, name;
        Type type;
        VariableDeclarationStatement stmt;
        Arguments arg;

        public Method(string modifier, Type type, string name, Arguments arg, VariableDeclarationStatement stmt)
        {
            this.modifier = modifier;
            this.type = type;
            this.name = name;
            this.arg = arg;
            this.stmt = stmt;
        }

        public override void dump(int indent)
        {
            label(indent, "Method Modifier :{0}\n", modifier);
            type.dump(indent);
            label(indent, "Method Declaration :{0}\n", name);
            arg.dump(indent);
            label(indent + 1, "MethodBody\n");
            stmt.dump(indent);
        }
    }
}
