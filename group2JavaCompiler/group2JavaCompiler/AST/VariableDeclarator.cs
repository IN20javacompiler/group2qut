using System;

namespace group2JavaCompiler.AST
{
    public class VariableDeclarator : Node
    {
        private VariableDeclaratorId id;

        private Expression init;
        public VariableDeclarator(VariableDeclaratorId id)
        {
            this.id = id;
        }

        public VariableDeclarator(VariableDeclaratorId id, Expression init)
        {
            this.id = id;
            this.init = init;
        }
        public override void dump(int indent)
        {
            throw new NotImplementedException();
        }
    }
}
