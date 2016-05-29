using System;
using System.Collections.Generic;

namespace group2JavaCompiler.AST
{
    public class FieldDeclaration : Node
    {
        VariableDeclarationStatement varDeclarationstmt;
        string modifier, name;
        List<VariableDeclarationStatement> variableList;
        Type type;

        public FieldDeclaration(string modifier, Type type, VariableDeclarationStatement variable)
        {
            this.modifier = modifier;
            this.type = type;
            this.varDeclarationstmt = variable;
        }
        public FieldDeclaration(string modifier, Type type, List<VariableDeclarationStatement> variable)
        {
            this.modifier = modifier;
            this.type = type;
            this.variableList = variable;
        }
        public override void dump(int indent)
        {
            throw new NotImplementedException();
        }
    }
}
