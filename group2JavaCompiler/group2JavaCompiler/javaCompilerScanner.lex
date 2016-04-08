%using javaCompiler.Parser;
%namespace javaCompiler.Lexer

%visibility public

Eol             (\r\n?|\n)
NotWh           [^ \t\r\n]
Space           [ \t]

Digit			[0-9]
Letter 			[a-zA-Z]
Identifier		\$([a-zA-Z]([a-zA-Z0-9_])*)
IntegerLiteral	{Digit}+
BooleanLiteral	(true|false)

Public      	public
Static      	static
Void        	void
Main			main
Class			class
Bool			bool
Int				int
String			string
OpAssign		=
OpAdd			+
OpMinus			"-"
OpMul			"*"
OpDiv			"/"
OpModul			"%"
OpAnd			and
OpOr			or
OpNot			not
OpEqu			"=="
OpNotEqu		"!="
OpLt			"<"
OpGt			">"
OpGtEq			">="
OpLtEq			"<="
OpSqLBr			"["
OpSqRBr			"]"
LeftPar			"("
RigthPar		")"
OpLtBrace		"{"
OpRtBrace		"}"
SemiColon		";"
%%
{Identifier}					{ yylval.String = yytext.Substring(1); return (int) Tokens.IDENTIFIER; }
{IntegerLiteral}				{ yylval.Integer = int.Parse(yytext); return (int)Tokens.INTEGER_LITERAL; }
{Bool}							{ bool.TryParse(yytext, out yylval.Bool); return (int) Tokens.BOOL; }
{Public}						{ return (int)Tokens.PUBLIC; }
{Static}						{ return (int)Tokens.STATIC; }
{Void}							{ return (int)Tokens.VOID; }
{Main}							{ return (int)Tokens.MAIN; }
{Class}							{ return (int)Tokens.CLASS; }
{Int}							{ return (int) Tokens.INT; }
{String}						{ return (int) Tokens.STRING; }
{OpAssign}						{ return (int) Tokens.OP_ASSIGN; }
{OpAdd}							{ return (int) Tokens.OP_ADD; }
{OpMinus}						{ return (int) Tokens.OP_MINUS; }
{OpMul}							{ return (int) Tokens.OP_MUL; }
{OpDiv}							{ return (int) Tokens.OP_DIV; }
{OpModul}						{ return (int) Tokens.OP_MODUL; }
{OpAnd}							{ return (int) Tokens.OP_AND; }
{OpOr}							{ return (int) Tokens.OP_OR; }
{OpNot}							{ return (int) Tokens.OP_NOT; }
{OpEqu}							{ return (int) Tokens.OP_EQU; }
{OpNotEqu}						{ return (int) Tokens.OP_NOT_EQU; }
{OpLt}							{ return (int) Tokens.OP_LT; }
{OpGt}							{ return (int) Tokens.OP_GT; }
{OpGtEq}						{ return (int) Tokens.OP_GT_EQ; }
{OpLtEq}						{ return (int) Tokens.OP_LT_EQ; }
{LeftPar}						{ return (int) Tokens.OP_LEFT_PAR; }
{RigthPar}						{ return (int) Tokens.OP_RIGHT_PAR; }
{OpSqLBr}						{ return (int) Tokens.OP_SQ_L_BR; }
{OpSqRBr}						{ return (int) Tokens.OP_SQ_R_BR; }
{OpLtBrace}						{ return (int) Tokens.OP_LT_BRACE; }
{OpRtBrace}						{ return (int) Tokens.OP_RT_BRACE; }
{SemiColon}						{ return (int) Tokens.SEMICOLON; }
%%