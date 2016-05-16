using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group2JavaCompiler.AST
{
    class LexicalScope
    {

        protected LexicalScope parentScope;

        Dictionary<string, Declaration> symbol_table = new Dictionary<string, Declaration>();

        public LexicalScope()
        {
            parentScope = null;
            symbol_table.Clear();
        }

        public Declaration ResolveHere(string symbol)
        {
            /*
            Dictionary<string, Declaration> iterator it = symbol_table.Find(symbol);
            if (it != symbol_table.end())
                return it->second;
            return null;
            */

            foreach (KeyValuePair<string, Declaration> symbolTable in symbol_table)
            {
                // do something with symbolTable.Value or entry.Key
                if (symbolTable.Key == symbol) 
                    return symbolTable.Value;
                return null;
            }
        }
    }
}
