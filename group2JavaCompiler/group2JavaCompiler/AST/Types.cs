using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group2JavaCompiler.AST
{
    abstract class Type { }

    class NamedType : Type
    {

        string name;
        public NamedType(string name)
        {
            this.name = name;
        }
    }

    class ArrayType : Type
    {
        Type elementType; 
        public ArrayType(Type elementType)
        {
            this.elementType = elementType;
        }
    }
}
