using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group2JavaCompiler.AST
{
    class ClassModifier : Node
    {

        ClassModifier str1,str2;

        public ClassModifier()
        {
        }

        public ClassModifier(ClassModifier str)
        {
            this.str1 = str1;
        }

        public ClassModifier(ClassModifier str, ClassModifier str2)
        {
            this.str1 = str1;
            this.str2 = str2;
        }

        public override void dump(int indent)
        {
            label(indent, "Class Modifier\n");
            str1.dump(indent + 1);
            str2.dump(indent + 1);
        }
    }
}
