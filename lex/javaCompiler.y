%namespace javaCompiler.parser

%output=javaCompilerParser.cs
%union {
    public long Integer;
    public string String;
  	public bool Bool;
}
%token <String>	 IDENTIFIER
%token <Integer> INTEGER_LITERAL
%token <Bool>	 BOOL_LITERAL

%token PUBLIC
%token STATIC
%token VOID
%token MAIN
%token CLASS
%token DIM
%token BOOL
%token INT
%token STRING
%token OP_LEFT_PAR
%token OP_SQ_L_BR
%token OP_SQ_R_BR

//left associated operands
%left OP_ASSIGN
%left OP_ADD OP_MINUS
%left OP_MUL OP_DIV 
%left OP_MODUL
%left OP_AND
%left OP_OR
%left OP_NOT
%left OP_EQU
%left OP_NOT_EQU
%left OP_LT
%left OP_GT
%left OP_GT_EQ
%left OP_LT_EQ

%start CompilationUnit
// YACC Rules
%%
CompilationUnit
	: ProgramFile
        ;

ProgramFile
	: PackageStatement ImportStatements TypeDeclarations
	| PackageStatement ImportStatements
	| PackageStatement                  TypeDeclarations
	|                  ImportStatements TypeDeclarations
	| PackageStatement
	|                  ImportStatements
	|                                   TypeDeclarations
	;

%%