using System;

namespace group2JavaCompiler.AST
{
    public class Method : Node
    {
        public string modifier, name;
        public Type type;
        public VariableDeclarationStatement stmt;
        public Parameter parameters;
        public CompoundStatement body;

        public Method(Type type, String name)
        {
            // this.modifier = modifiers;
            this.type = type;
            this.name = name;
        }

        public Method(Type type, String name, Parameter parameters)
        {
            //this.modifier = modifiers;
            this.type = type;
            this.name = name;
            this.parameters = parameters;
        }

        public Method(Type type, String name, Parameter parameters, CompoundStatement body)
        {
            //this.modifier = modifiers;
            this.type = type;
            this.name = name;
            this.parameters = parameters;
            this.body = body;
        }

        public override void dump(int indent)
        {
            label(indent, "Method Modifier :{0}\n", modifier);
            type.dump(indent);
            label(indent, "Method Declaration :{0}\n", name);
            label(indent + 1, "MethodBody\n");
            stmt.dump(indent);
        }
    }
}