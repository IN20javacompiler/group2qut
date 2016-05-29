﻿using System.Collections.Generic;
namespace group2JavaCompiler.AST { 
    public abstract class Statement : Node
    {

    }
    public class IfStatement : Statement
    {
        private Expression cond;
        private Statement thenStmt, elseStmt;

        public IfStatement(Expression cond, Statement thenStmt, Statement elseStmt)
        {
            this.cond = cond;
            this.thenStmt = thenStmt;
            this.elseStmt = elseStmt;
        }

        public override void dump(int indent)
        {
            label(indent, "IfStatement\n");
            cond.dump(indent + 1, "cond");
            thenStmt.dump(indent + 1, "then");
            elseStmt.dump(indent + 1, "else");
        }
    };

   

    public class VariableDeclaration : Statement
    {
        private Type type;
        private char name;
        public VariableDeclaration(Type type, char name)
        {
            this.type = type;
            this.name = name;
        }
        public override void dump(int indent)
        {
            label(indent, "VariableDeclaration {0}\n", name);
            type.dump(indent + 1);
        }
    };
    public class VariableDeclarationList : Statement
    {
        private Type type;
        List<VariableDeclarator> name;
        public VariableDeclarationList(Type type, List<VariableDeclarator> name)
        {
            this.type = type;
            this.name = name;
        }
        public override void dump(int indent)
        {
            label(indent, "VariableDeclarationList {0}\n", name);
            foreach (var child in name)
                child.dump(indent + 1);
        }
       };
    public class ExpressionStatement : Statement
    {
        private Expression expr;

        public ExpressionStatement(Expression expr)
        {
            this.expr = expr;
        }

        public override void dump(int indent)
        {
            label(indent, "ExpressionStatement\n");
            expr.dump(indent + 1);
        }
    };
    public class CompoundStatement : Statement
    {
        private List<Statement> stmts;

        public CompoundStatement(List<Statement> stmts)
        {
            this.stmts = stmts;
        }

        public override void dump(int indent)
        {
            label(indent, "CompoundStatement\n");
            foreach (var child in stmts)
                child.dump(indent + 1);
        }
    };
    public class VariableDeclarationStatement : Statement
    {
        private Type type;
        private IdentifierExpression name;
        private NumberExpression value;

        public VariableDeclarationStatement(Type type, IdentifierExpression name, NumberExpression value)
        {
            this.type = type;
            this.name = name;
            this.value = value;
        }

        public override void dump(int indent)
        {
            label(indent + 1, "VariableDeclarationStatement\n");
            type.dump(indent + 2);
            name.dump(indent + 2);
            value.dump(indent + 2);
        }
    };
    public class IfThenElseStatement : Statement
    {
        private Expression cond;
        private Statement thenStmt, elseStmt;

        public IfThenElseStatement(Expression cond, Statement thenStmt, Statement elseStmt)
        {
            this.cond = cond;
            this.thenStmt = thenStmt;
            this.elseStmt = elseStmt;
        }

        public override void dump(int indent)
        {
            label(indent, "IfThenElseStatement\n");
            cond.dump(indent + 1, "cond");
            thenStmt.dump(indent + 1, "then");
            elseStmt.dump(indent + 1, "else");
        }
    };
 }
