.assembly ConsoleApplication4 {}

.class private ConsoleApplication4.Program extends [mscorlib]System.Object
{
  .method private static void  Main(string[] args)
  {
    .entrypoint
    ldstr      "hello world"
    call       void [mscorlib]System.Console::WriteLine(string)
    ret
  }
} 

