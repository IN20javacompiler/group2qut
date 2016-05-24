%namespace group2JavaCompiler

%output=javaCompilerParser.cs
%{
public static AST.Class root;
%}

%union
{
    public AST.Expression expr;
	public AST.Statement stmt;
	public AST.Type type;
	public System.Collections.Generic.List<AST.Statement> stmts;
    public int Integer;
    public string String;
  	public bool Bool;
}
%type <expr> Expression
%type <stmt> Statement


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

CompilationUnit							:TypeDeclaration
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
										|IDENTIFIER
										;
TypeDeclaration							:ClassDeclaration
										;
ClassDeclaration						:NormalClassDeclaration 
										;
NormalClassDeclaration					: ClassModifiers CLASS IDENTIFIER OP_LT_BRACE ClassMemberDeclaration OP_RT_BRACE
										| CLASS IDENTIFIER OP_LT_BRACE ClassMemberDeclaration OP_RT_BRACE
										;
ClassModifiers							:ClassModifier ClassModifiers
										|ClassModifier
										;
ClassModifier							:PUBLIC 
										|PROTECTED
										|PRIVATE
										|ABSTRACT
										|STATIC
										|FINAL 
										|STRICTFP
										;
Annotation								:PUBLIC 
										|PROTECTED
										|PRIVATE
										|ABSTRACT
										|STATIC
										|FINAL 
										;
ClassMemberDeclaration					:MethodDeclaration 
										|FieldDeclaration 
										;
FieldDeclaration						: UnannType VariableDeclaratorList 
										|FieldModifier UnannType VariableDeclaratorList 
										;
FieldModifier							:Annotation;
MethodDeclaration						: MethodModifiers MethodHeader MethodBody
										|MethodHeader MethodBody;
MethodModifiers							:MethodModifier MethodModifiers
										|MethodModifier;
MethodModifier							:PUBLIC 
										|PROTECTED
										|PRIVATE
										|ABSTRACT
										|STATIC
										|FINAL 
										|SYNCHRONIZED
										|NATIVE
										|STRICTFP
										;
MethodHeader							:Result MethodDeclarator
										;
Result									:VOID
										;
MethodDeclarator						:IDENTIFIER OP_LEFT_PAR FormalParameterList OP_RIGHT_PAR
										|IDENTIFIER OP_LEFT_PAR OP_RIGHT_PAR
										;
FormalParameterList						:LastFormalParameter
										;
LastFormalParameter						:FormalParameter
										;
FormalParameter							:UnannType VariableDeclaratorId
										;
UnannType								:UnannReferenceType
										|UnannPrimitiveType
										;
UnannReferenceType						:UnannArrayType
										;
UnannArrayType							:UnannTypeVariable Dims
										;
UnannTypeVariable						:IDENTIFIER
										;

Dims									:OP_SQ_L_BR OP_SQ_R_BR
										;
MethodBody								:Block
										;
Block									: OP_LT_BRACE BlockStatements OP_RT_BRACE
										;
BlockStatements							:BlockStatement
										|BlockStatement OP_LT_BRACE BlockStatement OP_RT_BRACE 
										;
BlockStatement							:LocalVariableDeclarationStatement
										|Statement 
										;
Statement								:StatementWithoutTrailingSubstatement 
										|IfThenElseStatement
										;
IfThenElseStatement						:IF OP_LEFT_PAR Expression OP_RIGHT_PAR Statement ELSE Statement  { $$.stmt = new AST.IfStatement($3, $5, $7); }
										;

StatementWithoutTrailingSubstatement 	:OP_LT_BRACE Statement OP_RT_BRACE  
										|ExpressionStatement 
										|EmptyStatement
										;
EmptyStatement							:SEMICOLON
										;
ExpressionStatement						:StatementExpression SEMICOLON
										;
StatementExpression						:ExpressionName OP_ASSIGN Expression
										|MethodInvocation
										;
ExpressionName							:IDENTIFIER
										;
MethodInvocation						:MethodName OP_LEFT_PAR ArgumentList OP_RIGHT_PAR
										;
MethodName								:SYSTEM OP_DOT OUT OP_DOT PRINTLN
										;
ArgumentList							:Expression
										;
Expression								:AssignmentExpression
										|LambdaExpression 
										;
LambdaExpression						:LambdaParameters OP_ARROW LambdaBody
										;
LambdaParameters						:OP_DOUBLE_QUOTE IDENTIFIER OP_DOUBLE_QUOTE
										;
LambdaBody								:Block
										;
LocalVariableDeclarationStatement		:LocalVariableDeclaration SEMICOLON
										;
LocalVariableDeclaration				:UnannType VariableDeclaratorList
										;
UnannPrimitiveType						:NumericType
										;
NumericType								:IntegralType
										;
IntegralType							:INT
										;
VariableDeclaratorList					:VariableDeclarator
										;
VariableDeclarator						:VariableDeclaratorId OP_EQU VariableInitializer
										;
VariableDeclaratorId					:IDENTIFIER
										;
VariableInitializer						:Expression
										;
AssignmentExpression					:ConditionalExpression
										|ExpressionName OP_ASSIGN Expression;
							
ConditionalExpression					: ConditionalOrExpression
										;
ConditionalOrExpression					: ConditionalAndExpression
										;
ConditionalAndExpression				: InclusiveOrExpression
										;
InclusiveOrExpression					: ExclusiveOrExpression 
										;
ExclusiveOrExpression					: AndExpression
										;
AndExpression							: EqualityExpression
										;
EqualityExpression						: RelationalExpression
										;
RelationalExpression					:ShiftExpression
										;
ShiftExpression							:AdditiveExpression
										;
AdditiveExpression						:MultiplicativeExpression
										;
MultiplicativeExpression				:UnaryExpression
										;
UnaryExpression							:UnaryExpressionNotPlusMinus
										;
UnaryExpressionNotPlusMinus    			:PostfixExpression 
										;
PostfixExpression						:Primary 
										;
Primary									:PrimaryNoNewArray 
										;
PrimaryNoNewArray						:Literal 
										;
Literal 								:INTEGER_LITERAL 
										;
%%

public Parser(Scanner scanner) : base(scanner)
{
}