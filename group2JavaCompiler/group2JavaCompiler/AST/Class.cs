using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group2JavaCompiler
{
    class Class : Node
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
            label(indent, "ClassDeclaration {0}\n", name);
            label(indent + 1, "Modifier {0}\n", modifier);
            method.dump(indent + 1);
        }
    }
}
