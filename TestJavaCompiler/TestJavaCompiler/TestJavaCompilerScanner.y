%namespace TestJavaCompiler

%visibility public

Eol             	(\r\n?|\n)
NotWh           	[^ \t\r\n]
Space           	[ \t]
Digit			[0-9]+
Letter 			[a-zA-Z]
Identifier		[a-zA-Z][a-zA-Z0-9_]*
BooleanLiteral		(true|false)
Import			import
Public      		public
Static      		static
Void        		void
Class			class
While			while

%%

{While}							{ return (int) Tokens.While; }
{Identifier}						{ yylval.String = yytext; return (int) Tokens.IDENTIFIER; }

%%

public override void yyerror( string format, params object[] args ) 
{
Console.Error.WriteLine(format, args); 
}
