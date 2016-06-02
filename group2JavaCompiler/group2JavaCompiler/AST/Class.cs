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
        ClassMemberDeclaration member;
       

        public Class( string name, ClassMemberDeclaration member)
        {
           
            this.name = name;
            this.member = member;
            //this.modifier = modifier;
        }

        public Class(string modifier)
        {

            
            this.modifier = modifier;
        }
        public override void dump(int indent)
        {
            label(indent, "Class Modifier :{0}\n", modifier);
            label(indent, "Class Declaration \n");
            label(indent, "Class name Identifier :{0}\n", name);
            member.dump(indent + 1);
            
        }
    }
    public class ClassMemberDeclaration : Node
    {
        FieldDeclaration field;
        Method method;

        public ClassMemberDeclaration(Method method)
        {
            this.method = method;
        }
        public override void dump(int indent)
        {
            label(indent, "Class Member Declaration\n");
            //label(indent, "Class Modifier :{0}\n", modifier);
            method.dump(indent + 1);
        }
    };
}
