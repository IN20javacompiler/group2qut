/*
* Bison uses .y spec file to generate a parser.
* ( y.tab.c & y.tab.h )
* Parser reads a series of tokens and tries to determine the gramatical structure with respect tp given grammer.
*/

/* Definitions Section */
%{

%}

%token IDENTIFIER
%token NUMBER
%token STRINGLITERAL
%token LPAREM
%token RPAREM
%token LBRACE
%token RBRACE
%token EQUAL
%token PLUS
%token MINUS
%token MUL
%token DIV
%token MOD
%token PUBLIC_KEYWORD
%token STATIC_KEYWORD
%token VOID_KEYWORD
%token CLASS_KEYWORD
%token IF_KEYWORD
%token ELSE_KEYWORD
%token WHILE_KEYWORD
%token FOR_KEYWORD
%token INT_KEYWORD
%token FLOAT_KEYWORD
%token RETURN_KEYWORD
%token SEMICOLON

/* Rules Section */
%%


%%

/* C Code Section */


