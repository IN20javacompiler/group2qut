%namespace TestJavaCompiler


%token <String>	 IDENTIFIER 
%token <num> NUMBER
%token <Bool>	 BOOL_LITERAL
%token PUBLIC PROTECTED PRIVATE ABSTRACT STATIC FINAL SYNCHRONIZED NATIVE STRICTFP
%token VOID
%token EXPRESSION_STATEMENT 
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
%token WHILE
%token OP_ARROW


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

ClassDeclaration						:NormalClassDeclaration  	
										;
NormalClassDeclaration					:ClassModifiers CLASS IDENTIFIER OP_LT_BRACE ClassMemberDeclaration OP_RT_BRACE
										;
ClassModifier							:PUBLIC 
										|PROTECTED
										|PRIVATE
										|ABSTRACT
										|STATIC
										|FINAL 
										|SYNCHRONIZED
										|NATIVE
										|STRICTFP
										;
ClassMemberDeclaration					:MethodDeclaration																
										|FieldDeclaration 
										;
MethodDeclaration						:MethodModifiers Result IDENTIFIER OP_LEFT_PAR FormalParameterList OP_RIGHT_PAR MethodBody
										;
FieldDeclaration						: UnannType VariableDeclaratorList 
										|FieldModifier UnannType VariableDeclaratorList 
										;
MethodModifiers							:MethodModifier MethodModifiers
										|MethodModifier
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
Result									:VOID																			
										;
FormalParameterList						:LastFormalParameter															
										|FormalParameter
										;
UnannType								:UnannReferenceType
										|UnannPrimitiveType 															 
										;
VariableDeclaratorList					:VariableDeclaratorList VariableDeclarator										
										;
FieldModifier							:Annotation
										;
LastFormalParameter						:FormalParameter																
										;
FormalParameter							:UnannType VariableDeclaratorId													
										;
UnannReferenceType						:UnannArrayType
										;
UnannPrimitiveType						:NumericType 																	 
										;
VariableDeclarator						:VariableDeclaratorId															
										|VariableDeclaratorId OP_EQU VariableInitializer 								
										;
Annotation								:PUBLIC
										|PROTECTED
										|PRIVATE
										|ABSTRACT
										|STATIC
										|FINAL
										|SYNCHRONIZED
										|NATIVE
										|STRICTFP
										;
VariableDeclaratorId 					:IDENTIFIER																		
										;
UnannArrayType							:UnannTypeVariable Dims
										;
NumericType								:IntegralType																	 
										;
VariableInitializer						:Expression 																	 
										;
UnannTypeVariable						:IDENTIFIER
										;
Dims									:OP_SQ_L_BR OP_SQ_R_BR
										;
Expression								:AssignmentExpression   														 
										;
AssignmentExpression					:ConditionalExpression 															 
										|ExpressionName OP_EQU Expression   											 
										;
ConditionalExpression					:ConditionalOrExpression   													 
										;
ExpressionName							:IDENTIFIER
										;
ConditionalOrExpression					:ConditionalAndExpression   													 
										;
ConditionalAndExpression				:InclusiveOrExpression    														 
										;
InclusiveOrExpression					:ExclusiveOrExpression    														 
										;
ExclusiveOrExpression					:AndExpression      															 
										;
AndExpression							:EqualityExpression   															 
										;
EqualityExpression						:RelationalExpression   														 
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
Literal 								:NUMBER 																 
										;
IntegralType							:INT    																		 
										;
MethodBody								:Block 																			 
										;
Block									:OP_LT_BRACE BlockStatements OP_RT_BRACE 										 
										;
BlockStatements							:BlockStatements BlockStatement									 				
										|BlockStatement																					
										;
BlockStatement							:LocalVariableDeclaration SEMICOLON   											
										|Statement 
										;
Statement								:StatementWithoutTrailingSubstatement 	
										|WhileStatement
										;
StatementWithoutTrailingSubstatement 	:OP_LT_BRACE Statement OP_RT_BRACE  
										|ExpressionStatement 
										|EmptyStatement
										;
WhileStatement							:WHILE OP_LEFT_PAR Expression OP_RIGHT_PAR Statement
										;	
ExpressionStatement						:StatementExpression SEMICOLON
										;
EmptyStatement							:SEMICOLON
										;
StatementExpression						:ExpressionName OP_EQU Expression
										|MethodInvocation
										;
MethodInvocation						:MethodName OP_LEFT_PAR ArgumentList OP_RIGHT_PAR
										;
MethodName								:IDENTIFIER
										;
ArgumentList							:Expression
										;
CompilationUnit							:TypeDeclaration																 
										|ImportDeclaration
										|ImportDeclaration TypeDeclaration
										;
TypeDeclaration							:ClassDeclaration
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

%%

public Parser(Scanner scanner) : base(scanner)
{
}  
















