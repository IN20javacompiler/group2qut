using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace group2JavaCompiler.AST
{
    public class VariableDeclarator : Node
    {
        private VariableDeclaratorId id;

        private Expression init;
        public VariableDeclarator(VariableDeclaratorId id)
        {
            this.id=id;
        }

            public VariableDeclarator(VariableDeclaratorId id, Expression init)
        {
            this.id = id;
            this.init = init;
        }
        public override void dump(int indent)
        {
            //label(indent, "Variable Declaration\n");
            id.dump(indent);

            init.dump(indent);

        }
        public void gencode(StreamWriter codewriter)
        {
            id.gencode(codewriter);
            codewriter.Write("=");
            init.gencode(codewriter);
            codewriter.WriteLine(";");
        }
    }
}
