using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group2JavaCompiler.AST
{
    class IdentifierExpression
    {
        private string name;
        public IdentifierExpression(string name)
        {
            this.name = name;
        }
    }
}
