.assembly javacompiler {}

.class private javacompiler.Program extends [mscorlib]System.Object
{
  .method private static void  Main(string[] args)
  {
    .entrypoint
    
     .locals init ([0] int32 x)
      ldc.i4.s   42
      stloc.0
    ret
  }
} 
