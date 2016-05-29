using System;

namespace group2JavaCompiler.AST
{
    public class VariableDeclaratorId : Node
    {
        private String name;

        private int arrayCount;

        public VariableDeclaratorId()
        {
        }

        public VariableDeclaratorId(String name)
        {
            this.name = name;
        }

        public VariableDeclaratorId(String name, int arrayCount)
        {
            this.name = name;
            this.arrayCount = arrayCount;
        }
        public override void dump(int indent)
        {
            throw new NotImplementedException();
        }
    }
}
