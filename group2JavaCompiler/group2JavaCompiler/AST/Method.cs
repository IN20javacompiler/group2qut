using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group2JavaCompiler.AST {

    class Method{
        string methodModifier, methodName, methodType;
        public  Method (string methodModifier,  string methodType, string methodName)
        {
            this.methodName = methodName;
            this.methodType = methodType;
            this.methodModifier = methodModifier;
        }
    }
}
