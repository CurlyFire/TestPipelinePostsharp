using System;
using PostSharp.Aspects;
using PostSharp.Serialization;

namespace Aspects
{
    [PSerializable]
    public class SayHelloAttribute : OnMethodBoundaryAspect
    {
        public override void OnEntry(MethodExecutionArgs args)
        {
            base.OnEntry(args);
            Console.WriteLine("hello from postsharp");
            Console.ReadKey();
        }
    }
}
