using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group2JavaCompiler.AST
{
    public class Class : Node
    {
        string modifier, name;
        Method method;

        public Class(string modifier, string name, Method method)
        {
            this.modifier = modifier;
            this.name = name;
            this.method = method;
        }

        public override void dump(int indent)
        {
            label(indent, "Class Modifier :{0}\n", modifier);
            label(indent, "Class name Identifier :{0}\n", name);
            method.dump(indent + 1);
        }
    }
}
