﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public VariableDeclaratorId( String name, int arrayCount)
        {
            this.name = name;
            this.arrayCount=arrayCount;
        }
        public override void dump(int indent)
        {
            label(indent, "Variable Declaration id :{0}",name);
        }
    }
}
