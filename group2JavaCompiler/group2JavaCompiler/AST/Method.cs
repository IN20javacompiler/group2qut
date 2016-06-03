using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group2JavaCompiler.AST
{
    public class Method : Node
    {
        public string modifier, name;
        public Type type;
        public VariableDeclarationStatement stmt;
        public Parameter parameters;
        public CompoundStatement body;
        //private MethodName mdName;
        //private ArgumentList argList;

        public Method(Type type, String name)
        {
           // this.modifier = modifiers;
            this.type = type;
            this.name = name;
        }
        /*public Method(MethodName mdName, ArgumentList argList)
        {
            this.mdName = mdName;
            this.argList = argList;
        }*/
        public Method( Type type, String name, Parameter parameters)
        {
            //this.modifier = modifiers;
            this.type = type;
            this.name = name;
            this.parameters = parameters;
        }
        public Method( Type type, String name,  CompoundStatement body)
        {
            //this.modifier = modifiers;
            this.type = type;
            this.name = name;
           // this.parameters = parameters;
            this.body = body;
        }

        public override void dump(int indent)
        {
           
            type.dump(indent);
            label(indent, "Method Declaration :{0}\n", name);
           // parameters.dump(indent);
            label(indent + 1, "MethodBody\n");
            body.dump(indent);
        }
    }
    public abstract class MethodName : Node
    {
        
    }
    public abstract class ArgumentList : Node
    {
      
    }
    public class MethodInvocation : Node
    {
       public MethodName mdName;
        public ArgumentList argList;

        public MethodInvocation(MethodName mdName, ArgumentList argList)
        {
            this.mdName = mdName;
            this.argList = argList;
           
        }

        public override void dump(int indent)
        {
            label(indent, "Method Invocation\n");
            
            mdName.dump(indent + 1, "System.out.println");
            argList.dump(indent + 1, "Expression");
        }
    }

}