// This code was generated by the Gardens Point Parser Generator
// Copyright (c) Wayne Kelly, John Gough, QUT 2005-2014
// (see accompanying GPPGcopyright.rtf)

// GPPG version 1.5.2
// Machine:  SUJITHGEETHU
// DateTime: 13-04-2016 7.37.50 AM
// UserName: Sujith Geethu
// Input file <javaCompilerParser.y - 08-04-2016 8.37.50 PM>

// options: lines gplex

using System;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using System.Globalization;
using System.Text;
using QUT.Gppg;

namespace javaCompiler.Parser
{
public enum Tokens {error=2,EOF=3,IDENTIFIER=4,INTEGER_LITERAL=5,BOOL_LITERAL=6,
    PUBLIC=7,STATIC=8,VOID=9,MAIN=10,CLASS=11,BOOL=12,
    INT=13,STRING=14,OP_LEFT_PAR=15,OP_RIGHT_PAR=16,OP_SQ_L_BR=17,OP_SQ_R_BR=18,
    OP_LT_BRACE=19,OP_RT_BRACE=20,SEMICOLON=21,OP_ASSIGN=22,OP_ADD=23,OP_MINUS=24,
    OP_MUL=25,OP_DIV=26,OP_MODUL=27,OP_AND=28,OP_OR=29,OP_NOT=30,
    OP_EQU=31,OP_NOT_EQU=32,OP_LT=33,OP_GT=34,OP_GT_EQ=35,OP_LT_EQ=36};

public struct ValueType
#line 5 "javaCompilerParser.y"
       {
    public int Integer;
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
#pragma warning disable 649
  private static Dictionary<int, string> aliases;
#pragma warning restore 649
  private static Rule[] rules = new Rule[59];
  private static State[] states = new State[84];
  private static string[] nonTerms = new string[] {
      "CompilationUnit", "$accept", "TypeDeclaration", "ClassDeclaration", "NormalClassDeclaration", 
      "ClassModifier", "ClassBody", "ClassBodyDeclaration", "ClassMemberDeclaration", 
      "MethodDeclaration", "MethodModifier", "MethodHeader", "MethodBody", "Result", 
      "MethodDeclarator", "FormalParameterList", "LastFormalParameter", "FormalParameter", 
      "UnannType", "VariableDeclaratorId", "UnannReferenceType", "UnannPrimitiveType", 
      "UnannArrayType", "UnannTypeVariable", "Dims", "Block", "BlockStatements", 
      "BlockStatement", "LocalVariableDeclarationStatement", "LocalVariableDeclaration", 
      "VariableDeclaratorList", "NumericType", "IntegralType", "VariableDeclarator", 
      "VariableInitializer", "Expression", "AssignmentExpression", "ConditionalExpression", 
      "ConditionalOrExpression", "ConditionalAndExpression", "InclusiveOrExpression", 
      "ExclusiveOrExpression", "AndExpression", "EqualityExpression", "RelationalExpression", 
      "ShiftExpression", "AdditiveExpression", "MultiplicativeExpression", "UnaryExpression", 
      "UnaryExpressionNotPlusMinus", "PostfixExpression", "Primary", "PrimaryNoNewArray", 
      "Literal", };

  static Parser() {
    states[0] = new State(new int[]{7,80,11,81},new int[]{-1,1,-3,3,-4,4,-5,5,-6,6});
    states[1] = new State(new int[]{3,2});
    states[2] = new State(-1);
    states[3] = new State(-2);
    states[4] = new State(-3);
    states[5] = new State(-4);
    states[6] = new State(new int[]{11,7});
    states[7] = new State(new int[]{4,8});
    states[8] = new State(new int[]{19,10},new int[]{-7,9});
    states[9] = new State(-5);
    states[10] = new State(new int[]{7,76,9,75},new int[]{-8,11,-9,13,-10,14,-11,15,-12,78,-14,64});
    states[11] = new State(new int[]{20,12});
    states[12] = new State(-8);
    states[13] = new State(-9);
    states[14] = new State(-10);
    states[15] = new State(new int[]{9,75},new int[]{-12,16,-14,64});
    states[16] = new State(new int[]{19,19},new int[]{-13,17,-26,18});
    states[17] = new State(-11);
    states[18] = new State(-27);
    states[19] = new State(new int[]{4,59,13,63},new int[]{-27,20,-28,22,-29,23,-30,24,-19,26,-21,53,-23,54,-24,55,-22,60,-32,61,-33,62});
    states[20] = new State(new int[]{20,21});
    states[21] = new State(-28);
    states[22] = new State(-29);
    states[23] = new State(-30);
    states[24] = new State(new int[]{21,25});
    states[25] = new State(-31);
    states[26] = new State(new int[]{4,52},new int[]{-31,27,-34,28,-20,29});
    states[27] = new State(-32);
    states[28] = new State(-36);
    states[29] = new State(new int[]{31,30});
    states[30] = new State(new int[]{5,51},new int[]{-35,31,-36,32,-37,33,-38,34,-39,35,-40,36,-41,37,-42,38,-43,39,-44,40,-45,41,-46,42,-47,43,-48,44,-49,45,-50,46,-51,47,-52,48,-53,49,-54,50});
    states[31] = new State(-37);
    states[32] = new State(-39);
    states[33] = new State(-40);
    states[34] = new State(-41);
    states[35] = new State(-42);
    states[36] = new State(-43);
    states[37] = new State(-44);
    states[38] = new State(-45);
    states[39] = new State(-46);
    states[40] = new State(-47);
    states[41] = new State(-48);
    states[42] = new State(-49);
    states[43] = new State(-50);
    states[44] = new State(-51);
    states[45] = new State(-52);
    states[46] = new State(-53);
    states[47] = new State(-54);
    states[48] = new State(-55);
    states[49] = new State(-56);
    states[50] = new State(-57);
    states[51] = new State(-58);
    states[52] = new State(-38);
    states[53] = new State(-21);
    states[54] = new State(-23);
    states[55] = new State(new int[]{17,57},new int[]{-25,56});
    states[56] = new State(-24);
    states[57] = new State(new int[]{18,58});
    states[58] = new State(-26);
    states[59] = new State(-25);
    states[60] = new State(-22);
    states[61] = new State(-33);
    states[62] = new State(-34);
    states[63] = new State(-35);
    states[64] = new State(new int[]{4,66},new int[]{-15,65});
    states[65] = new State(-14);
    states[66] = new State(new int[]{15,67});
    states[67] = new State(new int[]{16,70,4,59,13,63},new int[]{-16,68,-17,71,-18,72,-19,73,-21,53,-23,54,-24,55,-22,60,-32,61,-33,62});
    states[68] = new State(new int[]{16,69});
    states[69] = new State(-16);
    states[70] = new State(-17);
    states[71] = new State(-18);
    states[72] = new State(-19);
    states[73] = new State(new int[]{4,52},new int[]{-20,74});
    states[74] = new State(-20);
    states[75] = new State(-15);
    states[76] = new State(new int[]{8,77});
    states[77] = new State(-13);
    states[78] = new State(new int[]{19,19},new int[]{-13,79,-26,18});
    states[79] = new State(-12);
    states[80] = new State(-7);
    states[81] = new State(new int[]{4,82});
    states[82] = new State(new int[]{19,10},new int[]{-7,83});
    states[83] = new State(-6);

    for (int sNo = 0; sNo < states.Length; sNo++) states[sNo].number = sNo;

    rules[1] = new Rule(-2, new int[]{-1,3});
    rules[2] = new Rule(-1, new int[]{-3});
    rules[3] = new Rule(-3, new int[]{-4});
    rules[4] = new Rule(-4, new int[]{-5});
    rules[5] = new Rule(-5, new int[]{-6,11,4,-7});
    rules[6] = new Rule(-5, new int[]{11,4,-7});
    rules[7] = new Rule(-6, new int[]{7});
    rules[8] = new Rule(-7, new int[]{19,-8,20});
    rules[9] = new Rule(-8, new int[]{-9});
    rules[10] = new Rule(-9, new int[]{-10});
    rules[11] = new Rule(-10, new int[]{-11,-12,-13});
    rules[12] = new Rule(-10, new int[]{-12,-13});
    rules[13] = new Rule(-11, new int[]{7,8});
    rules[14] = new Rule(-12, new int[]{-14,-15});
    rules[15] = new Rule(-14, new int[]{9});
    rules[16] = new Rule(-15, new int[]{4,15,-16,16});
    rules[17] = new Rule(-15, new int[]{4,15,16});
    rules[18] = new Rule(-16, new int[]{-17});
    rules[19] = new Rule(-17, new int[]{-18});
    rules[20] = new Rule(-18, new int[]{-19,-20});
    rules[21] = new Rule(-19, new int[]{-21});
    rules[22] = new Rule(-19, new int[]{-22});
    rules[23] = new Rule(-21, new int[]{-23});
    rules[24] = new Rule(-23, new int[]{-24,-25});
    rules[25] = new Rule(-24, new int[]{4});
    rules[26] = new Rule(-25, new int[]{17,18});
    rules[27] = new Rule(-13, new int[]{-26});
    rules[28] = new Rule(-26, new int[]{19,-27,20});
    rules[29] = new Rule(-27, new int[]{-28});
    rules[30] = new Rule(-28, new int[]{-29});
    rules[31] = new Rule(-29, new int[]{-30,21});
    rules[32] = new Rule(-30, new int[]{-19,-31});
    rules[33] = new Rule(-22, new int[]{-32});
    rules[34] = new Rule(-32, new int[]{-33});
    rules[35] = new Rule(-33, new int[]{13});
    rules[36] = new Rule(-31, new int[]{-34});
    rules[37] = new Rule(-34, new int[]{-20,31,-35});
    rules[38] = new Rule(-20, new int[]{4});
    rules[39] = new Rule(-35, new int[]{-36});
    rules[40] = new Rule(-36, new int[]{-37});
    rules[41] = new Rule(-37, new int[]{-38});
    rules[42] = new Rule(-38, new int[]{-39});
    rules[43] = new Rule(-39, new int[]{-40});
    rules[44] = new Rule(-40, new int[]{-41});
    rules[45] = new Rule(-41, new int[]{-42});
    rules[46] = new Rule(-42, new int[]{-43});
    rules[47] = new Rule(-43, new int[]{-44});
    rules[48] = new Rule(-44, new int[]{-45});
    rules[49] = new Rule(-45, new int[]{-46});
    rules[50] = new Rule(-46, new int[]{-47});
    rules[51] = new Rule(-47, new int[]{-48});
    rules[52] = new Rule(-48, new int[]{-49});
    rules[53] = new Rule(-49, new int[]{-50});
    rules[54] = new Rule(-50, new int[]{-51});
    rules[55] = new Rule(-51, new int[]{-52});
    rules[56] = new Rule(-52, new int[]{-53});
    rules[57] = new Rule(-53, new int[]{-54});
    rules[58] = new Rule(-54, new int[]{5});
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

#line 160 "javaCompilerParser.y"
public Parser(javaCompiler.Lexer.Scanner scanner) : base(scanner)
{
}
#line default
}
}
