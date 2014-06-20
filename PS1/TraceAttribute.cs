using System;
using System.Diagnostics;
using PostSharp.Aspects;

namespace PS1
{
    /*
     Aspect must be made serializable.
     */
    [Serializable]
    public sealed class TraceAttribute: OnMethodBoundaryAspect
    {
        private readonly string category;

        public TraceAttribute(string category)
        {
            this.category = category;
        }

        public string Category { get { return category; } }

        public override void OnEntry(MethodExecutionArgs args)
        {
            Trace.WriteLine(string.Format("Entering {0}.{1}.",args.Method.DeclaringType.Name, args.Method.Name), 
                            this.category);
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            Trace.WriteLine(string.Format("Leaving {0}.{1}.", args.Method.DeclaringType.Name, args.Method.Name), 
                            this.category);
        } 
    }
}