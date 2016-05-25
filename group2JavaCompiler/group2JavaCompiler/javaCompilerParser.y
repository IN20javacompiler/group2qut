%namespace group2JavaCompiler

%output=javaCompilerParser.cs
%{
public static AST.Class root;
%}

%union
{
    public AST.Expression expr;
	public AST.Statement stmt;
	public AST.Method method;
	public AST.Type type;
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

CompilationUnit							:TypeDeclaration						{$$=$1;}
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
ClassDeclaration						:NormalClassDeclaration  {$$=$1;}
										;
NormalClassDeclaration					: ClassModifiers CLASS IDENTIFIER OP_LT_BRACE ClassMemberDeclaration OP_RT_BRACE {$$ =new AST.Class($3,$5);}
																				;
ClassModifiers							: ClassModifier ClassModifiers
										|
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
ClassMemberDeclaration					:MethodDeclaration {$$=$1;}
										|FieldDeclaration 
										;
FieldDeclaration						: UnannType VariableDeclaratorList 
										|FieldModifier UnannType VariableDeclaratorList 
										;

FieldModifier							:Annotation
										;

MethodDeclaration						:MethodModifiers MethodHeader MethodBody {$2.stmt=$3;$$=$2;}
										;

MethodModifiers							:MethodModifier MethodModifiers
										|
										;

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
MethodHeader							:Result MethodDeclarator {$2.type=$1;$$=$2;}
										;
Result									:VOID {$$= new AST.NamedType("void");}
										;
MethodDeclarator						:IDENTIFIER OP_LEFT_PAR FormalParameterList OP_RIGHT_PAR {$$=new AST.Method($1,$3);}
										;
FormalParameterList						:LastFormalParameter
										|
										;
LastFormalParameter						:FormalParameter
										;
FormalParameter							:UnannType VariableDeclaratorId
										;
UnannType								:UnannReferenceType
										|UnannPrimitiveType {$$=$1;}
										;
UnannReferenceType						:UnannArrayType
										;
UnannArrayType							:UnannTypeVariable Dims
										;
UnannTypeVariable						:IDENTIFIER
										;

Dims									:OP_SQ_L_BR OP_SQ_R_BR
										;
MethodBody								:Block {$$=$1;}
										;
Block									: OP_LT_BRACE BlockStatements OP_RT_BRACE {$$=$2;}
										;
BlockStatements							:BlockStatement BlockStatements
										|
										;

BlockStatement							:LocalVariableDeclarationStatement {$$=$1;}
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
Expression								:AssignmentExpression   {$$=$1;}
										;
LocalVariableDeclarationStatement		:LocalVariableDeclaration SEMICOLON  {$$=$1;}
										;
LocalVariableDeclaration				:UnannType VariableDeclaratorList {$2.type=$1; $$=$2;}
										;
UnannPrimitiveType						:NumericType {$$=$1;}
										;
NumericType								:IntegralType{$$=$1;}
										;
IntegralType							:INT    {$$=new AST.IntType();}
										;
VariableDeclaratorList					:VariableDeclarator {$$=$1;}
										;
VariableDeclarator						:VariableDeclaratorId OP_EQU VariableInitializer {$$=new AST.VariableDeclarationStatement($1,$2);}
										;
VariableDeclaratorId					:IDENTIFIER {$$=$1;}
										;
VariableInitializer						:Expression {$$=$1;}
										;
AssignmentExpression					:ConditionalExpression {$$=$1;}
										|ExpressionName OP_ASSIGN Expression   {$$=new AST.AssignExpression($1,$3);}
										;
							
ConditionalExpression					: ConditionalOrExpression   {$$=$1;}
										;
ConditionalOrExpression					: ConditionalAndExpression   {$$=$1;}
										;
ConditionalAndExpression				: InclusiveOrExpression    {$$=$1;}
										;
InclusiveOrExpression					: ExclusiveOrExpression    {$$=$1;}
										;
ExclusiveOrExpression					: AndExpression      {$$=$1;}
										;
AndExpression							: EqualityExpression   {$$=$1;}
										;
EqualityExpression						: RelationalExpression   {$$=$1;}
										;
RelationalExpression					:ShiftExpression    {$$=$1;}
										;
ShiftExpression							:AdditiveExpression   {$$=$1;}
										;
AdditiveExpression						:MultiplicativeExpression   {$$=$1;}
										;
MultiplicativeExpression				:UnaryExpression    {$$=$1;}
										;
UnaryExpression							:UnaryExpressionNotPlusMinus    {$$=$1;}
										;
UnaryExpressionNotPlusMinus    			:PostfixExpression    {$$=$1;}
										;
PostfixExpression						:Primary    {$$=$1;}
										;
Primary									:PrimaryNoNewArray    {$$=$1;}
										;
PrimaryNoNewArray						:Literal     {$$=$1; }
										;
Literal 								:INTEGER_LITERAL {$$= new AST.IntegerLiteralExpression($1);}
										;
%%

public Parser(Scanner scanner) : base(scanner)
{
}