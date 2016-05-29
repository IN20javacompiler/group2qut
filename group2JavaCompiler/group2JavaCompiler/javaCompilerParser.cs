// This code was generated by the Gardens Point Parser Generator
// Copyright (c) Wayne Kelly, John Gough, QUT 2005-2014
// (see accompanying GPPGcopyright.rtf)

// GPPG version 1.5.2
// Machine:  PRETTYPC
// DateTime: 5/29/2016 4:15:55 PM
// UserName: Pretty
// Input file <javaCompilerParser.y - 5/29/2016 4:15:23 PM>

// options: lines gplex

using System;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using System.Globalization;
using System.Text;
using QUT.Gppg;

namespace group2JavaCompiler
{
public enum Tokens {error=2,EOF=3,IDENTIFIER=4,NUMBER=5,BOOL_LITERAL=6,
    PUBLIC=7,PROTECTED=8,PRIVATE=9,ABSTRACT=10,STATIC=11,FINAL=12,
    SYNCHRONIZED=13,NATIVE=14,STRICTFP=15,VOID=16,EXPRESSION_STATEMENT=17,MAIN=18,
    CLASS=19,BOOL=20,INT=21,STRING=22,IMPORT=23,OP_LEFT_PAR=24,
    OP_RIGHT_PAR=25,OP_SQ_L_BR=26,OP_SQ_R_BR=27,OP_LT_BRACE=28,OP_RT_BRACE=29,SEMICOLON=30,
    OP_DOT=31,SYSTEM=32,OUT=33,PRINTLN=34,IF=35,ELSE=36,
    OP_ARROW=37,OP_ASSIGN=38,OP_ADD=39,OP_MINUS=40,OP_MUL=41,OP_DIV=42,
    OP_MODUL=43,OP_AND=44,OP_OR=45,OP_NOT=46,OP_EQU=47,OP_NOT_EQU=48,
    OP_LT=49,OP_GT=50,OP_GT_EQ=51,OP_LT_EQ=52,OP_DOUBLE_QUOTE=53};

public struct ValueType
#line 9 "javaCompilerParser.y"
{
    public AST.Expression expr;
	public AST.Statement stmt;
	public AST.CompoundStatement compoundStmt;
	public AST.ClassMemberDeclaration member;
	public AST.Method method;
	public AST.Type type;
	public AST.Parameter param;
	public AST.VariableDeclarator varDeclarator;
	public AST.VariableDeclaratorId varDeclaratorId;
	public AST.VariableDeclarationExpr varDeclaratorExpr;
	public AST.Class classRoot;
	public System.Collections.Generic.List<AST.Statement> stmts;
	public System.Collections.Generic.List<AST.VariableDeclarator> varList;
	public int num;
    public string String;
  	public bool Bool;
	
}
#line default
// Abstract base class for GPLEX scanners
[GeneratedCodeAttribute( "Gardens Point Parser Generator", "1.5.2")]
public abstract class ScanBase : AbstractScanner<ValueType,LexLocation> {
  private LexLocation __yylloc = new LexLocation();
  public override LexLocation yylloc { get { return __yylloc; } set { __yylloc = value; } }
  protected virtual bool yywrap() { return true; }
}

// Utility class for encapsulating token information
[GeneratedCodeAttribute( "Gardens Point Parser Generator", "1.5.2")]
public class ScanObj {
  public int token;
  public ValueType yylval;
  public LexLocation yylloc;
  public ScanObj( int t, ValueType val, LexLocation loc ) {
    this.token = t; this.yylval = val; this.yylloc = loc;
  }
}

[GeneratedCodeAttribute( "Gardens Point Parser Generator", "1.5.2")]
public class Parser: ShiftReduceParser<ValueType, LexLocation>
{
  // Verbatim content from javaCompilerParser.y - 5/29/2016 4:15:23 PM
#line 5 "javaCompilerParser.y"
public static AST.Class root;
#line default
  // End verbatim content from javaCompilerParser.y - 5/29/2016 4:15:23 PM

#pragma warning disable 649
  private static Dictionary<int, string> aliases;
#pragma warning restore 649
  private static Rule[] rules = new Rule[106];
  private static State[] states = new State[149];
  private static string[] nonTerms = new string[] {
      "VariableDeclarator", "VariableDeclaratorId", "ExpressionName", "VariableDeclaratorList", 
      "LocalVariableDeclaration", "FormalParameterList", "LastFormalParameter", 
      "FormalParameter", "UnannType", "Result", "IntegralType", "NumericType", 
      "UnannPrimitiveType", "ClassMemberDeclaration", "Expression", "VariableInitializer", 
      "AssignmentExpression", "ConditionalExpression", "ConditionalAndExpression", 
      "ConditionalOrExpression", "InclusiveOrExpression", "ExclusiveOrExpression", 
      "AndExpression", "EqualityExpression", "RelationalExpression", "ShiftExpression", 
      "AdditiveExpression", "MultiplicativeExpression", "UnaryExpression", "UnaryExpressionNotPlusMinus", 
      "PostfixExpression", "Primary", "PrimaryNoNewArray", "Literal", "Statement", 
      "BlockStatement", "MethodBody", "Block", "BlockStatements", "MethodDeclaration", 
      "NormalClassDeclaration", "CompilationUnit", "ClassDeclaration", "$accept", 
      "ClassModifiers", "FieldDeclaration", "MethodModifiers", "MethodModifier", 
      "UnannReferenceType", "StatementWithoutTrailingSubstatement", "IfThenElseStatement", 
      "ExpressionStatement", "EmptyStatement", "StatementExpression", "MethodInvocation", 
      "MethodName", "ArgumentList", "TypeDeclaration", "ImportDeclaration", "SingleTypeImportDeclaration", 
      "TypeName", "PackageOrTypeName", "ClassModifier", "Annotation", "FieldModifier", 
      "UnannArrayType", "UnannTypeVariable", "Dims", };

  static Parser() {
    states[0] = new State(new int[]{7,133,8,134,9,135,10,136,11,137,12,138,15,139,23,143,19,-85},new int[]{-42,1,-58,3,-43,4,-41,5,-45,6,-63,131,-59,140,-60,142});
    states[1] = new State(new int[]{3,2});
    states[2] = new State(-1);
    states[3] = new State(-75);
    states[4] = new State(-83);
    states[5] = new State(-2);
    states[6] = new State(new int[]{19,7});
    states[7] = new State(new int[]{4,8});
    states[8] = new State(new int[]{28,9});
    states[9] = new State(new int[]{7,118,8,119,9,120,10,121,11,122,12,123,13,115,14,116,15,117,4,105,21,68,16,-8},new int[]{-14,10,-40,12,-47,13,-48,107,-46,124,-9,125,-49,58,-66,59,-67,60,-13,65,-12,66,-11,67,-65,127,-64,130});
    states[10] = new State(new int[]{29,11});
    states[11] = new State(-3);
    states[12] = new State(-4);
    states[13] = new State(new int[]{16,106},new int[]{-10,14});
    states[14] = new State(new int[]{4,15});
    states[15] = new State(new int[]{24,16});
    states[16] = new State(new int[]{4,105,21,68,25,-11},new int[]{-6,17,-7,101,-8,102,-9,103,-49,58,-66,59,-67,60,-13,65,-12,66,-11,67});
    states[17] = new State(new int[]{25,18});
    states[18] = new State(new int[]{28,21},new int[]{-37,19,-38,20});
    states[19] = new State(-6);
    states[20] = new State(-19);
    states[21] = new State(-22,new int[]{-39,22});
    states[22] = new State(new int[]{29,23,4,64,21,68,28,71,32,86,30,92,35,94},new int[]{-36,24,-5,25,-9,27,-49,58,-66,59,-67,60,-13,65,-12,66,-11,67,-35,69,-50,70,-52,74,-54,75,-3,77,-55,80,-56,81,-53,91,-51,93});
    states[23] = new State(-20);
    states[24] = new State(-21);
    states[25] = new State(new int[]{30,26});
    states[26] = new State(-23);
    states[27] = new State(-28,new int[]{-4,28});
    states[28] = new State(new int[]{4,57,30,-26},new int[]{-1,29,-2,30});
    states[29] = new State(-27);
    states[30] = new State(new int[]{47,31,4,-29,30,-29,29,-29});
    states[31] = new State(new int[]{5,52,4,56},new int[]{-16,32,-15,33,-17,34,-18,35,-20,36,-19,37,-21,38,-22,39,-23,40,-24,41,-25,42,-26,43,-27,44,-28,45,-29,46,-30,47,-31,48,-32,49,-33,50,-34,51,-3,53});
    states[32] = new State(-30);
    states[33] = new State(-31);
    states[34] = new State(-32);
    states[35] = new State(-33);
    states[36] = new State(-35);
    states[37] = new State(-36);
    states[38] = new State(-37);
    states[39] = new State(-38);
    states[40] = new State(-39);
    states[41] = new State(-40);
    states[42] = new State(-41);
    states[43] = new State(-42);
    states[44] = new State(-43);
    states[45] = new State(-44);
    states[46] = new State(-45);
    states[47] = new State(-46);
    states[48] = new State(-47);
    states[49] = new State(-48);
    states[50] = new State(-49);
    states[51] = new State(-50);
    states[52] = new State(-51);
    states[53] = new State(new int[]{38,54});
    states[54] = new State(new int[]{5,52,4,56},new int[]{-15,55,-17,34,-18,35,-20,36,-19,37,-21,38,-22,39,-23,40,-24,41,-25,42,-26,43,-27,44,-28,45,-29,46,-30,47,-31,48,-32,49,-33,50,-34,51,-3,53});
    states[55] = new State(-34);
    states[56] = new State(-62);
    states[57] = new State(-25);
    states[58] = new State(-14);
    states[59] = new State(-102);
    states[60] = new State(new int[]{26,62},new int[]{-68,61});
    states[61] = new State(-103);
    states[62] = new State(new int[]{27,63});
    states[63] = new State(-105);
    states[64] = new State(new int[]{26,-104,38,-62});
    states[65] = new State(-15);
    states[66] = new State(-16);
    states[67] = new State(-17);
    states[68] = new State(-18);
    states[69] = new State(-24);
    states[70] = new State(-52);
    states[71] = new State(new int[]{28,71,4,56,32,86,30,92,35,94},new int[]{-35,72,-50,70,-52,74,-54,75,-3,77,-55,80,-56,81,-53,91,-51,93});
    states[72] = new State(new int[]{29,73});
    states[73] = new State(-55);
    states[74] = new State(-56);
    states[75] = new State(new int[]{30,76});
    states[76] = new State(-59);
    states[77] = new State(new int[]{38,78});
    states[78] = new State(new int[]{5,52,4,56},new int[]{-15,79,-17,34,-18,35,-20,36,-19,37,-21,38,-22,39,-23,40,-24,41,-25,42,-26,43,-27,44,-28,45,-29,46,-30,47,-31,48,-32,49,-33,50,-34,51,-3,53});
    states[79] = new State(-60);
    states[80] = new State(-61);
    states[81] = new State(new int[]{24,82});
    states[82] = new State(new int[]{5,52,4,56},new int[]{-57,83,-15,85,-17,34,-18,35,-20,36,-19,37,-21,38,-22,39,-23,40,-24,41,-25,42,-26,43,-27,44,-28,45,-29,46,-30,47,-31,48,-32,49,-33,50,-34,51,-3,53});
    states[83] = new State(new int[]{25,84});
    states[84] = new State(-63);
    states[85] = new State(-65);
    states[86] = new State(new int[]{31,87});
    states[87] = new State(new int[]{33,88});
    states[88] = new State(new int[]{31,89});
    states[89] = new State(new int[]{34,90});
    states[90] = new State(-64);
    states[91] = new State(-57);
    states[92] = new State(-58);
    states[93] = new State(-53);
    states[94] = new State(new int[]{24,95});
    states[95] = new State(new int[]{5,52,4,56},new int[]{-15,96,-17,34,-18,35,-20,36,-19,37,-21,38,-22,39,-23,40,-24,41,-25,42,-26,43,-27,44,-28,45,-29,46,-30,47,-31,48,-32,49,-33,50,-34,51,-3,53});
    states[96] = new State(new int[]{25,97});
    states[97] = new State(new int[]{28,71,4,56,32,86,30,92,35,94},new int[]{-35,98,-50,70,-52,74,-54,75,-3,77,-55,80,-56,81,-53,91,-51,93});
    states[98] = new State(new int[]{36,99});
    states[99] = new State(new int[]{28,71,4,56,32,86,30,92,35,94},new int[]{-35,100,-50,70,-52,74,-54,75,-3,77,-55,80,-56,81,-53,91,-51,93});
    states[100] = new State(-54);
    states[101] = new State(-10);
    states[102] = new State(-12);
    states[103] = new State(new int[]{4,57},new int[]{-2,104});
    states[104] = new State(-13);
    states[105] = new State(-104);
    states[106] = new State(-9);
    states[107] = new State(new int[]{7,109,8,110,9,111,10,112,11,113,12,114,13,115,14,116,15,117,16,-8},new int[]{-47,108,-48,107});
    states[108] = new State(-7);
    states[109] = new State(-66);
    states[110] = new State(-67);
    states[111] = new State(-68);
    states[112] = new State(-69);
    states[113] = new State(-70);
    states[114] = new State(-71);
    states[115] = new State(-72);
    states[116] = new State(-73);
    states[117] = new State(-74);
    states[118] = new State(new int[]{7,-66,8,-66,9,-66,10,-66,11,-66,12,-66,13,-66,14,-66,15,-66,16,-66,4,-93,21,-93});
    states[119] = new State(new int[]{7,-67,8,-67,9,-67,10,-67,11,-67,12,-67,13,-67,14,-67,15,-67,16,-67,4,-94,21,-94});
    states[120] = new State(new int[]{7,-68,8,-68,9,-68,10,-68,11,-68,12,-68,13,-68,14,-68,15,-68,16,-68,4,-95,21,-95});
    states[121] = new State(new int[]{7,-69,8,-69,9,-69,10,-69,11,-69,12,-69,13,-69,14,-69,15,-69,16,-69,4,-96,21,-96});
    states[122] = new State(new int[]{7,-70,8,-70,9,-70,10,-70,11,-70,12,-70,13,-70,14,-70,15,-70,16,-70,4,-97,21,-97});
    states[123] = new State(new int[]{7,-71,8,-71,9,-71,10,-71,11,-71,12,-71,13,-71,14,-71,15,-71,16,-71,4,-98,21,-98});
    states[124] = new State(-5);
    states[125] = new State(-28,new int[]{-4,126});
    states[126] = new State(new int[]{4,57,29,-99},new int[]{-1,29,-2,30});
    states[127] = new State(new int[]{4,105,21,68},new int[]{-9,128,-49,58,-66,59,-67,60,-13,65,-12,66,-11,67});
    states[128] = new State(-28,new int[]{-4,129});
    states[129] = new State(new int[]{4,57,29,-100},new int[]{-1,29,-2,30});
    states[130] = new State(-101);
    states[131] = new State(new int[]{7,133,8,134,9,135,10,136,11,137,12,138,15,139,19,-85},new int[]{-45,132,-63,131});
    states[132] = new State(-84);
    states[133] = new State(-86);
    states[134] = new State(-87);
    states[135] = new State(-88);
    states[136] = new State(-89);
    states[137] = new State(-90);
    states[138] = new State(-91);
    states[139] = new State(-92);
    states[140] = new State(new int[]{7,133,8,134,9,135,10,136,11,137,12,138,15,139,3,-76,19,-85},new int[]{-58,141,-43,4,-41,5,-45,6,-63,131});
    states[141] = new State(-77);
    states[142] = new State(-78);
    states[143] = new State(new int[]{4,148},new int[]{-61,144,-62,145});
    states[144] = new State(-79);
    states[145] = new State(new int[]{31,146});
    states[146] = new State(new int[]{4,147});
    states[147] = new State(new int[]{7,-80,8,-80,9,-80,10,-80,11,-80,12,-80,15,-80,19,-80,3,-80,31,-81});
    states[148] = new State(-82);

    for (int sNo = 0; sNo < states.Length; sNo++) states[sNo].number = sNo;

    rules[1] = new Rule(-44, new int[]{-42,3});
    rules[2] = new Rule(-43, new int[]{-41});
    rules[3] = new Rule(-41, new int[]{-45,19,4,28,-14,29});
    rules[4] = new Rule(-14, new int[]{-40});
    rules[5] = new Rule(-14, new int[]{-46});
    rules[6] = new Rule(-40, new int[]{-47,-10,4,24,-6,25,-37});
    rules[7] = new Rule(-47, new int[]{-48,-47});
    rules[8] = new Rule(-47, new int[]{});
    rules[9] = new Rule(-10, new int[]{16});
    rules[10] = new Rule(-6, new int[]{-7});
    rules[11] = new Rule(-6, new int[]{});
    rules[12] = new Rule(-7, new int[]{-8});
    rules[13] = new Rule(-8, new int[]{-9,-2});
    rules[14] = new Rule(-9, new int[]{-49});
    rules[15] = new Rule(-9, new int[]{-13});
    rules[16] = new Rule(-13, new int[]{-12});
    rules[17] = new Rule(-12, new int[]{-11});
    rules[18] = new Rule(-11, new int[]{21});
    rules[19] = new Rule(-37, new int[]{-38});
    rules[20] = new Rule(-38, new int[]{28,-39,29});
    rules[21] = new Rule(-39, new int[]{-39,-36});
    rules[22] = new Rule(-39, new int[]{});
    rules[23] = new Rule(-36, new int[]{-5,30});
    rules[24] = new Rule(-36, new int[]{-35});
    rules[25] = new Rule(-2, new int[]{4});
    rules[26] = new Rule(-5, new int[]{-9,-4});
    rules[27] = new Rule(-4, new int[]{-4,-1});
    rules[28] = new Rule(-4, new int[]{});
    rules[29] = new Rule(-1, new int[]{-2});
    rules[30] = new Rule(-1, new int[]{-2,47,-16});
    rules[31] = new Rule(-16, new int[]{-15});
    rules[32] = new Rule(-15, new int[]{-17});
    rules[33] = new Rule(-17, new int[]{-18});
    rules[34] = new Rule(-17, new int[]{-3,38,-15});
    rules[35] = new Rule(-18, new int[]{-20});
    rules[36] = new Rule(-20, new int[]{-19});
    rules[37] = new Rule(-19, new int[]{-21});
    rules[38] = new Rule(-21, new int[]{-22});
    rules[39] = new Rule(-22, new int[]{-23});
    rules[40] = new Rule(-23, new int[]{-24});
    rules[41] = new Rule(-24, new int[]{-25});
    rules[42] = new Rule(-25, new int[]{-26});
    rules[43] = new Rule(-26, new int[]{-27});
    rules[44] = new Rule(-27, new int[]{-28});
    rules[45] = new Rule(-28, new int[]{-29});
    rules[46] = new Rule(-29, new int[]{-30});
    rules[47] = new Rule(-30, new int[]{-31});
    rules[48] = new Rule(-31, new int[]{-32});
    rules[49] = new Rule(-32, new int[]{-33});
    rules[50] = new Rule(-33, new int[]{-34});
    rules[51] = new Rule(-34, new int[]{5});
    rules[52] = new Rule(-35, new int[]{-50});
    rules[53] = new Rule(-35, new int[]{-51});
    rules[54] = new Rule(-51, new int[]{35,24,-15,25,-35,36,-35});
    rules[55] = new Rule(-50, new int[]{28,-35,29});
    rules[56] = new Rule(-50, new int[]{-52});
    rules[57] = new Rule(-50, new int[]{-53});
    rules[58] = new Rule(-53, new int[]{30});
    rules[59] = new Rule(-52, new int[]{-54,30});
    rules[60] = new Rule(-54, new int[]{-3,38,-15});
    rules[61] = new Rule(-54, new int[]{-55});
    rules[62] = new Rule(-3, new int[]{4});
    rules[63] = new Rule(-55, new int[]{-56,24,-57,25});
    rules[64] = new Rule(-56, new int[]{32,31,33,31,34});
    rules[65] = new Rule(-57, new int[]{-15});
    rules[66] = new Rule(-48, new int[]{7});
    rules[67] = new Rule(-48, new int[]{8});
    rules[68] = new Rule(-48, new int[]{9});
    rules[69] = new Rule(-48, new int[]{10});
    rules[70] = new Rule(-48, new int[]{11});
    rules[71] = new Rule(-48, new int[]{12});
    rules[72] = new Rule(-48, new int[]{13});
    rules[73] = new Rule(-48, new int[]{14});
    rules[74] = new Rule(-48, new int[]{15});
    rules[75] = new Rule(-42, new int[]{-58});
    rules[76] = new Rule(-42, new int[]{-59});
    rules[77] = new Rule(-42, new int[]{-59,-58});
    rules[78] = new Rule(-59, new int[]{-60});
    rules[79] = new Rule(-60, new int[]{23,-61});
    rules[80] = new Rule(-61, new int[]{-62,31,4});
    rules[81] = new Rule(-62, new int[]{-62,31,4});
    rules[82] = new Rule(-62, new int[]{4});
    rules[83] = new Rule(-58, new int[]{-43});
    rules[84] = new Rule(-45, new int[]{-63,-45});
    rules[85] = new Rule(-45, new int[]{});
    rules[86] = new Rule(-63, new int[]{7});
    rules[87] = new Rule(-63, new int[]{8});
    rules[88] = new Rule(-63, new int[]{9});
    rules[89] = new Rule(-63, new int[]{10});
    rules[90] = new Rule(-63, new int[]{11});
    rules[91] = new Rule(-63, new int[]{12});
    rules[92] = new Rule(-63, new int[]{15});
    rules[93] = new Rule(-64, new int[]{7});
    rules[94] = new Rule(-64, new int[]{8});
    rules[95] = new Rule(-64, new int[]{9});
    rules[96] = new Rule(-64, new int[]{10});
    rules[97] = new Rule(-64, new int[]{11});
    rules[98] = new Rule(-64, new int[]{12});
    rules[99] = new Rule(-46, new int[]{-9,-4});
    rules[100] = new Rule(-46, new int[]{-65,-9,-4});
    rules[101] = new Rule(-65, new int[]{-64});
    rules[102] = new Rule(-49, new int[]{-66});
    rules[103] = new Rule(-66, new int[]{-67,-68});
    rules[104] = new Rule(-67, new int[]{4});
    rules[105] = new Rule(-68, new int[]{26,27});
  }

  protected override void Initialize() {
    this.InitSpecialTokens((int)Tokens.error, (int)Tokens.EOF);
    this.InitStates(states);
    this.InitRules(rules);
    this.InitNonTerminals(nonTerms);
  }

  protected override void DoAction(int action)
  {
#pragma warning disable 162, 1522
    switch (action)
    {
      case 2: // ClassDeclaration -> NormalClassDeclaration
#line 89 "javaCompilerParser.y"
                                                             {root=ValueStack[ValueStack.Depth-1].classRoot;}
#line default
        break;
      case 3: // NormalClassDeclaration -> ClassModifiers, CLASS, IDENTIFIER, OP_LT_BRACE, 
              //                           ClassMemberDeclaration, OP_RT_BRACE
#line 91 "javaCompilerParser.y"
                                                                                                           {CurrentSemanticValue.classRoot =new AST.Class(ValueStack[ValueStack.Depth-4].String,ValueStack[ValueStack.Depth-2].member);}
#line default
        break;
      case 4: // ClassMemberDeclaration -> MethodDeclaration
#line 93 "javaCompilerParser.y"
                                                             {CurrentSemanticValue.member= new AST.ClassMemberDeclaration(ValueStack[ValueStack.Depth-1].method);}
#line default
        break;
      case 6: // MethodDeclaration -> MethodModifiers, Result, IDENTIFIER, OP_LEFT_PAR, 
              //                      FormalParameterList, OP_RIGHT_PAR, MethodBody
#line 96 "javaCompilerParser.y"
                                                                                                                    {CurrentSemanticValue.method =new AST.Method(ValueStack[ValueStack.Depth-6].type,ValueStack[ValueStack.Depth-5].String,ValueStack[ValueStack.Depth-3].param,ValueStack[ValueStack.Depth-1].compoundStmt);}
#line default
        break;
      case 9: // Result -> VOID
#line 102 "javaCompilerParser.y"
                                       {CurrentSemanticValue.type= new AST.VoidType();}
#line default
        break;
      case 10: // FormalParameterList -> LastFormalParameter
#line 104 "javaCompilerParser.y"
                                                            {CurrentSemanticValue.param=ValueStack[ValueStack.Depth-1].param;}
#line default
        break;
      case 12: // LastFormalParameter -> FormalParameter
#line 107 "javaCompilerParser.y"
                                                         {CurrentSemanticValue.param=ValueStack[ValueStack.Depth-1].param;}
#line default
        break;
      case 13: // FormalParameter -> UnannType, VariableDeclaratorId
#line 109 "javaCompilerParser.y"
                                                                  {CurrentSemanticValue.param=new AST.Parameter(ValueStack[ValueStack.Depth-2].type,ValueStack[ValueStack.Depth-1].varDeclaratorId);}
#line default
        break;
      case 15: // UnannType -> UnannPrimitiveType
#line 112 "javaCompilerParser.y"
                                              {CurrentSemanticValue.type=ValueStack[ValueStack.Depth-1].type;}
#line default
        break;
      case 16: // UnannPrimitiveType -> NumericType
#line 114 "javaCompilerParser.y"
                                                       {CurrentSemanticValue.type=ValueStack[ValueStack.Depth-1].type;}
#line default
        break;
      case 17: // NumericType -> IntegralType
#line 116 "javaCompilerParser.y"
                                                  {CurrentSemanticValue.type=ValueStack[ValueStack.Depth-1].type;}
#line default
        break;
      case 18: // IntegralType -> INT
#line 118 "javaCompilerParser.y"
                                              {CurrentSemanticValue.type=new AST.IntType();}
#line default
        break;
      case 19: // MethodBody -> Block
#line 120 "javaCompilerParser.y"
                                             {CurrentSemanticValue.compoundStmt=ValueStack[ValueStack.Depth-1].compoundStmt;}
#line default
        break;
      case 20: // Block -> OP_LT_BRACE, BlockStatements, OP_RT_BRACE
#line 122 "javaCompilerParser.y"
                                                                  {CurrentSemanticValue.compoundStmt = new AST.CompoundStatement(ValueStack[ValueStack.Depth-2].stmts); }
#line default
        break;
      case 21: // BlockStatements -> BlockStatements, BlockStatement
#line 124 "javaCompilerParser.y"
                                                                   {CurrentSemanticValue.stmts = ValueStack[ValueStack.Depth-2].stmts; CurrentSemanticValue.stmts.Add(ValueStack[ValueStack.Depth-1].stmt); }
#line default
        break;
      case 22: // BlockStatements -> /* empty */
#line 125 "javaCompilerParser.y"
                               { CurrentSemanticValue.stmts = new System.Collections.Generic.List<AST.Statement>(); }
#line default
        break;
      case 23: // BlockStatement -> LocalVariableDeclaration, SEMICOLON
#line 127 "javaCompilerParser.y"
                                                                      {CurrentSemanticValue.stmt = new AST.ExpressionStatement(ValueStack[ValueStack.Depth-2].varDeclaratorExpr);}
#line default
        break;
      case 25: // VariableDeclaratorId -> IDENTIFIER
#line 130 "javaCompilerParser.y"
                                                       {CurrentSemanticValue.varDeclaratorId=new AST.VariableDeclaratorId(ValueStack[ValueStack.Depth-1].String);}
#line default
        break;
      case 26: // LocalVariableDeclaration -> UnannType, VariableDeclaratorList
#line 132 "javaCompilerParser.y"
                                                                           {CurrentSemanticValue.varDeclaratorExpr=new AST.VariableDeclarationExpr(ValueStack[ValueStack.Depth-2].type,ValueStack[ValueStack.Depth-1].varList);}
#line default
        break;
      case 27: // VariableDeclaratorList -> VariableDeclaratorList, VariableDeclarator
#line 134 "javaCompilerParser.y"
                                                                               {CurrentSemanticValue.varList = ValueStack[ValueStack.Depth-2].varList; CurrentSemanticValue.varList.Add(ValueStack[ValueStack.Depth-1].varDeclarator); }
#line default
        break;
      case 28: // VariableDeclaratorList -> /* empty */
#line 135 "javaCompilerParser.y"
                               { CurrentSemanticValue.varList = new System.Collections.Generic.List<AST.VariableDeclarator>(); }
#line default
        break;
      case 29: // VariableDeclarator -> VariableDeclaratorId
#line 137 "javaCompilerParser.y"
                                                            {CurrentSemanticValue.varDeclarator=new AST.VariableDeclarator(ValueStack[ValueStack.Depth-1].varDeclaratorId);}
#line default
        break;
      case 30: // VariableDeclarator -> VariableDeclaratorId, OP_EQU, VariableInitializer
#line 138 "javaCompilerParser.y"
                                                                   {CurrentSemanticValue.varDeclarator=new AST.VariableDeclarator(ValueStack[ValueStack.Depth-3].varDeclaratorId,ValueStack[ValueStack.Depth-1].expr);}
#line default
        break;
      case 31: // VariableInitializer -> Expression
#line 140 "javaCompilerParser.y"
                                                       {CurrentSemanticValue.expr=ValueStack[ValueStack.Depth-1].expr;}
#line default
        break;
      case 32: // Expression -> AssignmentExpression
#line 142 "javaCompilerParser.y"
                                                         {CurrentSemanticValue.expr=ValueStack[ValueStack.Depth-1].expr;}
#line default
        break;
      case 33: // AssignmentExpression -> ConditionalExpression
#line 144 "javaCompilerParser.y"
                                                                {CurrentSemanticValue.expr=ValueStack[ValueStack.Depth-1].expr;}
#line default
        break;
      case 35: // ConditionalExpression -> ConditionalOrExpression
#line 148 "javaCompilerParser.y"
                                                                    {CurrentSemanticValue.expr=ValueStack[ValueStack.Depth-1].expr;}
#line default
        break;
      case 36: // ConditionalOrExpression -> ConditionalAndExpression
#line 150 "javaCompilerParser.y"
                                                                       {CurrentSemanticValue.expr=ValueStack[ValueStack.Depth-1].expr;}
#line default
        break;
      case 37: // ConditionalAndExpression -> InclusiveOrExpression
#line 152 "javaCompilerParser.y"
                                                                      {CurrentSemanticValue.expr=ValueStack[ValueStack.Depth-1].expr;}
#line default
        break;
      case 38: // InclusiveOrExpression -> ExclusiveOrExpression
#line 154 "javaCompilerParser.y"
                                                                    {CurrentSemanticValue.expr=ValueStack[ValueStack.Depth-1].expr;}
#line default
        break;
      case 39: // ExclusiveOrExpression -> AndExpression
#line 156 "javaCompilerParser.y"
                                                               {CurrentSemanticValue.expr=ValueStack[ValueStack.Depth-1].expr;}
#line default
        break;
      case 40: // AndExpression -> EqualityExpression
#line 158 "javaCompilerParser.y"
                                                           {CurrentSemanticValue.expr=ValueStack[ValueStack.Depth-1].expr;}
#line default
        break;
      case 41: // EqualityExpression -> RelationalExpression
#line 160 "javaCompilerParser.y"
                                                                {CurrentSemanticValue.expr=ValueStack[ValueStack.Depth-1].expr;}
#line default
        break;
      case 42: // RelationalExpression -> ShiftExpression
#line 162 "javaCompilerParser.y"
                                                             {CurrentSemanticValue.expr=ValueStack[ValueStack.Depth-1].expr;}
#line default
        break;
      case 43: // ShiftExpression -> AdditiveExpression
#line 164 "javaCompilerParser.y"
                                                            {CurrentSemanticValue.expr=ValueStack[ValueStack.Depth-1].expr;}
#line default
        break;
      case 44: // AdditiveExpression -> MultiplicativeExpression
#line 166 "javaCompilerParser.y"
                                                                  {CurrentSemanticValue.expr=ValueStack[ValueStack.Depth-1].expr;}
#line default
        break;
      case 45: // MultiplicativeExpression -> UnaryExpression
#line 168 "javaCompilerParser.y"
                                                                {CurrentSemanticValue.expr=ValueStack[ValueStack.Depth-1].expr;}
#line default
        break;
      case 46: // UnaryExpression -> UnaryExpressionNotPlusMinus
#line 170 "javaCompilerParser.y"
                                                                   {CurrentSemanticValue.expr=ValueStack[ValueStack.Depth-1].expr;}
#line default
        break;
      case 47: // UnaryExpressionNotPlusMinus -> PostfixExpression
#line 172 "javaCompilerParser.y"
                                                                        {CurrentSemanticValue.expr=ValueStack[ValueStack.Depth-1].expr;}
#line default
        break;
      case 48: // PostfixExpression -> Primary
#line 174 "javaCompilerParser.y"
                                                     {CurrentSemanticValue.expr=ValueStack[ValueStack.Depth-1].expr;}
#line default
        break;
      case 49: // Primary -> PrimaryNoNewArray
#line 176 "javaCompilerParser.y"
                                                      {CurrentSemanticValue.expr=ValueStack[ValueStack.Depth-1].expr;}
#line default
        break;
      case 50: // PrimaryNoNewArray -> Literal
#line 178 "javaCompilerParser.y"
                                                      {CurrentSemanticValue.expr=ValueStack[ValueStack.Depth-1].expr;}
#line default
        break;
      case 51: // Literal -> NUMBER
#line 180 "javaCompilerParser.y"
                                         {CurrentSemanticValue.expr = new AST.NumberExpression(ValueStack[ValueStack.Depth-1].num);}
#line default
        break;
      case 62: // ExpressionName -> IDENTIFIER
#line 198 "javaCompilerParser.y"
                                               {CurrentSemanticValue.varDeclaratorId=new AST.VariableDeclaratorId(ValueStack[ValueStack.Depth-1].String);}
#line default
        break;
    }
#pragma warning restore 162, 1522
  }

  protected override string TerminalToString(int terminal)
  {
    if (aliases != null && aliases.ContainsKey(terminal))
        return aliases[terminal];
    else if (((Tokens)terminal).ToString() != terminal.ToString(CultureInfo.InvariantCulture))
        return ((Tokens)terminal).ToString();
    else
        return CharToString((char)terminal);
  }

#line 267 "javaCompilerParser.y"

public Parser(Scanner scanner) : base(scanner)
{
}
#line default
}
}
