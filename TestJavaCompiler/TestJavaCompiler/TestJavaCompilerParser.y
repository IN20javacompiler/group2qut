%namespace TestJavaCompiler

%token PUBLIC STATIC
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
										|STATIC	
ClassMemberDeclaration					:MethodDeclaration																
										|FieldDeclaration 
MethodDeclaration						:MethodModifiers Result IDENTIFIER OP_LEFT_PAR FormalParameterList OP_RIGHT_PAR MethodBody
										;
FieldDeclaration						: UnannType VariableDeclaratorList 
										|FieldModifier UnannType VariableDeclaratorList 
										;
MethodModifiers							:MethodModifier MethodModifiers
										|
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
										|STATIC
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
IntegralType							:INT    																		 
										;

%%

public Parser(Scanner scanner) : base(scanner)
{
} 
















