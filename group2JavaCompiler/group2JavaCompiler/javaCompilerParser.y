%namespace group2JavaCompiler

%output=javaCompilerParser.cs

%{
	public static AST.Class root;
%}

%union {
	public AST.Expression expr;
	public AST.Statement stmt;
	public AST.Method method;
	public AST.Type type;
	public AST.Modifier modifier;
	public System.Collections.Generic.List<AST.Statement> stmts;
	
    public int Integer;
    public string String;
  	public bool Bool;
}

%type <expr> Expression
%type <method> MethodHeader MethodDeclarator MethodDeclaration

%token <String>	 IDENTIFIER
%token <Integer> INTEGER_LITERAL
%token <Bool>	 BOOL_LITERAL

%token PUBLIC PROTECTED PRIVATE ABSTRACT STATIC FINAL SYNCHRONIZED NATIVE STRICTFP
%token VOID
%token EXPRESSION_STATEMENT 
%token MAIN
%token CLASS
%token BOOL
%token INT
%token STRING
%token IMPORT
%token OP_LEFT_PAR
%token OP_RIGHT_PAR
%token OP_SQ_L_BR
%token OP_SQ_R_BR
%token OP_LT_BRACE OP_RT_BRACE
%token SEMICOLON
%token OP_DOT
%token SYSTEM
%token OUT
%token PRINTLN
%token IF
%token ELSE
%token OP_ARROW
%token BREAK
%token CONTINUE
%token DO
%token WHILE
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
%left OP_DOUBLE_QUOTE

%start CompilationUnit
// YACC Rules
%%
CompilationUnit							:TypeDeclaration											{ $$ = $1; }
										|ImportDeclaration
										|ImportDeclaration TypeDeclaration
										;
ImportDeclaration						:SingleTypeImportDeclaration
										;
SingleTypeImportDeclaration				:IMPORT TypeName 
										;
TypeName								:PackageOrTypeName OP_DOT IDENTIFIER
										;
PackageOrTypeName						:PackageOrTypeName OP_DOT IDENTIFIER
										|IDENTIFIER													{ $$ = new AST.IdentifierExpression($1); }
										;
TypeDeclaration							:ClassDeclaration											{ $$ = $1; }
										;
ClassDeclaration						:NormalClassDeclaration										{ $$ = $1; }
										;
NormalClassDeclaration					: ClassModifiers CLASS IDENTIFIER ClassBody					{ $$ = new AST.Class($1,$3,$4); }
										| CLASS IDENTIFIER ClassBody
										;
ClassModifiers							:ClassModifier ClassModifiers
										|ClassModifier												{ $$ = $1; }
										;
ClassModifier							:PUBLIC														{ $$ = new AST.Modifier($1); } 
										|PROTECTED
										|PRIVATE
										|ABSTRACT
										|STATIC
										|FINAL 
										|STRICTFP
										;
ClassBody								: OP_LT_BRACE ClassBodyDeclaration OP_RT_BRACE				{ $$ = $2; }
										;
ClassBodyDeclaration					:ClassMemberDeclaration										{ $$ = $1; }
										;
ClassMemberDeclaration					:MethodDeclaration											{ $$ = $1; } 
										;
MethodDeclaration						: MethodModifiers MethodHeader MethodBody					{ $2.stmt = $3; $$ = $2; }
										|MethodHeader MethodBody;
MethodModifiers							:MethodModifier MethodModifiers								{ $$ = $1; } 
										|MethodModifier												{ $$ = $1; }
										;											
MethodModifier							:PUBLIC														{ $$ = new AST.Modifier($1); }  
										|PROTECTED
										|PRIVATE
										|ABSTRACT
										|STATIC														{ $$ = new AST.Modifier($1); }  
										|FINAL 
										|SYNCHRONIZED
										|NATIVE
										|STRICTFP
										;
MethodHeader							:Result MethodDeclarator									{ $2.type = $1; $$ = $2; }
										;
Result									:VOID														{ $$ = new AST.NamedType("void"); }
										;
MethodDeclarator						:IDENTIFIER OP_LEFT_PAR FormalParameterList OP_RIGHT_PAR	{ $$ = new AST.Method($3); }
										|IDENTIFIER OP_LEFT_PAR OP_RIGHT_PAR
										;
FormalParameterList						:LastFormalParameter										{ $$ = $1; } 
										;
LastFormalParameter						:FormalParameter											{ $$ = $1; } 
										;
FormalParameter							:UnannType VariableDeclaratorId								{ $2.type = $1; $$ = $2; }
										;
UnannType								:UnannReferenceType											{ $$ = $1; } 
										|UnannPrimitiveType											{ $$ = $1; } 
										;
UnannReferenceType						:UnannArrayType												{ $$ = new AST.ArraType(new AST.NamedType(STRING)); } 
										;
UnannArrayType							:UnannTypeVariable Dims
										;
UnannTypeVariable						:IDENTIFIER													{ $$ = new AST.IdentifierExpression($1); }
										;

Dims									:OP_SQ_L_BR OP_SQ_R_BR
										;
MethodBody								:Block														{ $$ = $1; } 
										;
Block									: OP_LT_BRACE BlockStatements OP_RT_BRACE					{ $$ = new AST.CompoundStatement($2); }
										;
BlockStatements							:BlockStatement												{ $$ = $1; } 
										;
BlockStatement							:LocalVariableDeclarationStatement							{ $$ = $1; } 
										|Statement
										;
Statement								:StatementWithoutTrailingSubstatement 
										|IfThenElseStatement
										;
IfThenElseStatement						:IF OP_LEFT_PAR Expression OP_RIGHT_PAR StatementNoShortIf ELSE Statement
										;
StatementNoShortIf						:StatementWithoutTrailingSubstatement
										;
StatementWithoutTrailingSubstatement 	:ExpressionStatement
										|EmptyStatement
										|BreakStatement 
										|ContinueStatement 
										|DoStatement
										;
EmptyStatement							:SEMICOLON
										;
ExpressionStatement						:StatementExpression SEMICOLON
										;
BreakStatement							:BREAK IDENTIFIER SEMICOLON
										;
ContinueStatement						:CONTINUE IDENTIFIER SEMICOLON
										;	
DoStatement								:DO Statement WHILE OP_LEFT_PAR Expression OP_RIGHT_PAR SEMICOLON
										;
StatementExpression						:MethodInvocation
										;
MethodInvocation						:MethodName OP_LEFT_PAR ArgumentList OP_RIGHT_PAR
										;
MethodName								:SYSTEM OP_DOT OUT OP_DOT PRINTLN
										;
ArgumentList							:Expression
										;
Expression								:AssignmentExpression										{ $$ = $1; }
										|LambdaExpression 
										;
LambdaExpression						:LambdaParameters OP_ARROW LambdaBody
										;
LambdaParameters						:OP_DOUBLE_QUOTE IDENTIFIER OP_DOUBLE_QUOTE
										;
LambdaBody								:Block
										;
LocalVariableDeclarationStatement		:LocalVariableDeclaration SEMICOLON							{ $$ = $1; } 
										;
LocalVariableDeclaration				:UnannType VariableDeclaratorList							{ $2.type = $1; $$ = $2; } 
										;
UnannPrimitiveType						:NumericType
										;
NumericType								:IntegralType
										;
IntegralType							:INT														{ $$ = new AST.IntType(); }
										;
VariableDeclaratorList					:VariableDeclarator											{ $$ = $1; } 
										;
VariableDeclarator						:VariableDeclaratorId OP_EQU VariableInitializer			{ $$ = new AST.VariableDeclarationStatement($1,$3); }
										;
VariableDeclaratorId					:IDENTIFIER													{ $$ = new AST.IdentifierExpression($1); }
										;
VariableInitializer						:Expression													{ $$ = $1; }
										;
AssignmentExpression					:ConditionalExpression										{ $$ = $1; } 
										;
ConditionalExpression					: ConditionalOrExpression									{ $$ = $1; } 
										;
ConditionalOrExpression					: ConditionalAndExpression									{ $$ = $1; }
										;
ConditionalAndExpression				: InclusiveOrExpression										{ $$ = $1; }
										;
InclusiveOrExpression					: ExclusiveOrExpression										{ $$ = $1; } 
										;
ExclusiveOrExpression					: AndExpression												{ $$ = $1; }
										;
AndExpression							: EqualityExpression										{ $$ = $1; }
										;
EqualityExpression						: RelationalExpression										{ $$ = $1; }
										;
RelationalExpression					:ShiftExpression											{ $$ = $1; }
										;
ShiftExpression							:AdditiveExpression											{ $$ = $1; }
										;
AdditiveExpression						:MultiplicativeExpression									{ $$ = $1; }
										;
MultiplicativeExpression				:UnaryExpression											{ $$ = $1; }
										;
UnaryExpression							:UnaryExpressionNotPlusMinus								{ $$ = $1; }
										;
UnaryExpressionNotPlusMinus    			:PostfixExpression 											{ $$ = $1; }
										;
PostfixExpression						:Primary 													{ $$ = $1; }
										;
Primary									:PrimaryNoNewArray 											{ $$ = $1; }
										;
PrimaryNoNewArray						:Literal 													{ $$ = $1; }
										;
Literal 								:INTEGER_LITERAL 											{ $$ = new IntegerLiteralExpression($1); }
										;
%%

public Parser(javaCompiler.Lexer.Scanner scanner) : base(scanner)
{
}