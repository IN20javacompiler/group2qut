using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group2JavaCompiler.AST
{
    public abstract class Expression : Node
    {
       /* void Dump()
        {
            // using Reflection
        } */
    }
    public class AssignExpression : Expression
    {
        private Expression lhs, rhs;

        public AssignExpression(Expression lhs, Expression rhs)
        {
            this.lhs = lhs;
            this.rhs = rhs;
        }

        public override void dump(int indent)
        {
            label(indent, "AssignmentExpression\n");
            lhs.dump(indent + 1, "lhs");
            rhs.dump(indent + 1, "rhs");
        }
    };
    public class BinaryExpression : Expression
    {
        private char op;
        private Expression lhs, rhs;

        public BinaryExpression(Expression lhs, char op, Expression rhs)
        {
            this.op = op;
            this.lhs = lhs;
            this.rhs = rhs;
        }

        public override void dump(int indent)
        {
            label(indent, "BinaryExpression {0}\n", op);
            lhs.dump(indent + 1, "lhs");
            rhs.dump(indent + 1, "rhs");
        }
    };
    public class IdentifierExpression : Expression
    {
        private string name;

        public IdentifierExpression(string name)
        {
            this.name = name;
        }

        public override void dump(int indent)
        {
            label(indent, "IdentifierExpression {0}\n", name);
        }
       };
    public class NumberExpression : Expression
    {
        private int value;
        public NumberExpression(int value)
        {
            this.value = value;
        }
        public override void dump(int indent)
        {
            label(indent, "NumberExpression {0}\n", value);
        }
    };
    public class VariableDeclarationExpr : Expression
    {
        private Type type;
        private string modifiers;
        private List<VariableDeclarator> vars;
        public VariableDeclarationExpr()
        {
        }

        public VariableDeclarationExpr(Type type, List<VariableDeclarator> vars)
        {
            this.type = type;
            this.vars = vars;
        }

        public VariableDeclarationExpr(string modifiers, Type type, List<VariableDeclarator> vars)
        {
            this.modifiers = modifiers;
            this.type = type;
            this.vars = vars;
        }
        public override void dump(int indent)
        {
            label(indent, "VariableDeclarationExpr \n");
            type.dump(indent + 1);
            foreach (var child in vars) { 
                child.dump(indent + 1);
        }
           
        }
    };
}
