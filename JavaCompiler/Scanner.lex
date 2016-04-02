/* Definitions Section */
%namespace javacompiler.Scanner

letter			[a-zA-Z]
digit			[0-9]
stringliteral	\"([^\\\"]|\\.)*\"
lparem			(
rparem			)
lbrace			{
rbrace			}
equal			=
plus			+
minus			-
mul				*
div				/
mod				%
public_tok		public
static_tok		static
void_tok		void
class_tok		class
if_tok			if
else_tok		else
while_tok		while
for_tok			for
int_tok			int
float_tok		float
return_tok		return			
semicolon		;

/* Rules Section */
%%
{letter}({letter}|{digit})*		{ yylval.text = yytext; return (int)Tokens.IDENTIFIER; }
{digit}+						{ yylval.num = int.Parse(yytext); return (int)Tokens.NUMBER; }
{stringliteral}					{ yylval.text = yytext; return (int)Tokens.STRINGLITERAL; }
{lparem}						{ return (int)Tokens.LPAREM; }
{rparem}						{ return (int)Tokens.RPAREM; }
{lbrace}						{ return (int)Tokens.LBRACE; }
{rbrace}						{ return (int)Tokens.RBRACE; }
{equal}							{ return (int)Tokens.EQUAL; }
{plus}							{ return (int)Tokens.PLUS; }
{minus}							{ return (int)Tokens.MINUS; }
{mul}							{ return (int)Tokens.MUL; }
{div}							{ return (int)Tokens.DIV; }
{mod}							{ return (int)Tokens.MOD; }
{public_tok}					{ return (int)Tokens.PUBLIC_KEYWORD; }
{static_tok}					{ return (int)Tokens.STATIC_KEYWORD; }
{void_tok}						{ return (int)Tokens.VOID_KEYWORD; }
{class_tok}						{ return (int)Tokens.CLASS_KEYWORD; }
{if_tok}						{ return (int)Tokens.IF_KEYWORD; }
{else_tok}						{ return (int)Tokens.ELSE_KEYWORD; }
{while_tok}						{ return (int)Tokens.WHILE_KEYWORD; }
{for_tok}						{ return (int)Tokens.FOR_KEYWORD; }
{int_tok}						{ return (int)Tokens.INT_KEYWORD; }
{float_tok}						{ return (int)Tokens.FLOAT_KEYWORD; }
{return_tok}					{ return (int)Tokens.RETURN_KEYWORD; }
{semicolon}						{ return (int)Tokens.SEMICOLON; }
.|\n							{ /* Ignore all other characters. */ }
%%
