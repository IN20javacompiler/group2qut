using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group2JavaCompiler
{
    class Arguments : Expression
    {
        private string name;
        private ArrayType type;

        public Arguments(ArrayType type, string name)
        {
            this.type = type;
            this.name = name;
        }

        public override void dump(int indent)
        {
            label(indent, "Arguments :{0}", name);
            type.dump(indent);
        }
    }
}
