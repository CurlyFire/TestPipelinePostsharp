using System;
using PostSharp.Aspects;
using PostSharp.Serialization;

namespace Aspects
{
    [PSerializable]
    public class ThrowsAttribute : OnMethodBoundaryAspect
    {
        public override void OnEntry(MethodExecutionArgs args)
        {
            throw new Exception("Thrown from postsharp");
        }
    }
}
