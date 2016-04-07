%namespace javaCompiler.Parser

%output=Parser.cs

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
%token BOOL
%token INT
%token STRING
%token OP_LEFT_PAR
%token OP_RIGHT_PAR
%token OP_SQ_L_BR
%token OP_SQ_R_BR
%token OP_LT_BRACE OP_RT_BRACE
%token SEMICOLON
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
CompilationUnit					:TypeDeclaration
								;
TypeDeclaration					:ClassDeclaration
								;
ClassDeclaration				:NormalClassDeclaration
								;
NormalClassDeclaration			: ClassModifier CLASS IDENTIFIER ClassBody
								| CLASS IDENTIFIER ClassBody
								;
ClassModifier					:PUBLIC
								;
ClassBody						: OP_LT_BRACE ClassBodyDeclaration OP_RT_BRACE
								;
ClassBodyDeclaration			:ClassMemberDeclaration
								;
ClassMemberDeclaration			:MethodDeclaration 
								;
MethodDeclaration				: MethodModifier MethodHeader MethodBody
								|MethodHeader MethodBody;
MethodModifier					:PUBLIC STATIC
								;
MethodHeader					:Result MethodDeclarator
								;
Result							:VOID;
MethodDeclarator				:IDENTIFIER OP_LEFT_PAR FormalParameterList OP_RIGHT_PAR
								|IDENTIFIER OP_LEFT_PAR OP_RIGHT_PAR
								;
FormalParameterList				:LastFormalParameter
								;
LastFormalParameter				:FormalParameter
								;
FormalParameter					:UnannType VariableDeclaratorId
								;
UnannType						:UnannReferenceType
								|UnannPrimitiveType
								;
UnannReferenceType				:UnannArrayType
								;
UnannArrayType					:UnannTypeVariable Dims
								;
UnannTypeVariable				:IDENTIFIER;

Dims							:OP_SQ_L_BR OP_SQ_R_BR
								;
MethodBody						:Block
								;
Block							: OP_LT_BRACE BlockStatements OP_RT_BRACE
								;
BlockStatements					:BlockStatement
								;
BlockStatement					:LocalVariableDeclarationStatement
								;
LocalVariableDeclarationStatement: LocalVariableDeclaration SEMICOLON
								;
LocalVariableDeclaration		:UnannType VariableDeclaratorList
								;
UnannPrimitiveType				:NumericType
								;
NumericType						:IntegralType
								;
IntegralType					:INT;

VariableDeclaratorList			:VariableDeclarator
								;
VariableDeclarator				:VariableDeclaratorId OP_EQU VariableInitializer
								;
VariableDeclaratorId			:IDENTIFIER
								;
VariableInitializer				:Expression
								;
Expression						:AssignmentExpression
								;
AssignmentExpression			:ConditionalExpression
								;
ConditionalExpression			: ConditionalOrExpression
								;
ConditionalOrExpression			: ConditionalAndExpression
								;
ConditionalAndExpression		: InclusiveOrExpression
								;
InclusiveOrExpression			: ExclusiveOrExpression 
								;
ExclusiveOrExpression			: AndExpression
								;
AndExpression					: EqualityExpression
								;
EqualityExpression				: RelationalExpression
								;
RelationalExpression			:ShiftExpression
								;
ShiftExpression					:AdditiveExpression
								;
AdditiveExpression				:MultiplicativeExpression
								;
MultiplicativeExpression		:UnaryExpression
								;
UnaryExpression					:UnaryExpressionNotPlusMinus
								;
UnaryExpressionNotPlusMinus     :PostfixExpression 
								;
PostfixExpression				:Primary 
								;
Primary							:PrimaryNoNewArray 
								;

PrimaryNoNewArray				:Literal 
								;

Literal 						:INTEGER_LITERAL 
								;
						

%%