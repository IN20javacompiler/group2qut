﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace group2JavaCompiler.AST
{
    class PostFixExpression : Node
    {
        public override void dump(int indent)
        {
            label(indent, "PostFixExpression\n");
        }

        public override void codegeneration(StreamWriter codewriter);
    }

    public class IdenExp : Expression
    {
        private string name;

        public IdenExp(string name)
        {
            this.name = name;
        }

        public override void dump(int indent)
        {
            label(indent, "Identifier {0}\n", name);
        }
    };
    public class keyword : Expression
    {
        private string kword;

        public keyword(string kword)
        {
            this.kword = kword;
        }

        public override void dump(int indent)
        {
            label(indent, "Keyword {0}\n",kword);
        }
    };
    public class postfixexpression : Expression
    {
        private string pofixexp;

        public postfixexpression(string pofixexp)
        {
            this.pofixexp = pofixexp; 
        }

        public override void dump(int indent)
        {
            label(indent, "PostFixExpression {0}\n", pofixexp);
        }
    }
}