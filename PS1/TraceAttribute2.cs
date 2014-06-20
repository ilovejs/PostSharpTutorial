using System;
using PostSharp.Aspects;

namespace PS1
{
    /*
     Create a new class ending in the suffix Attribute, such as TraceAttribute. 
     */
    public sealed class Trace2Attribute : Attribute
    {
        private readonly string category;

        public Trace2Attribute(string category)
        {
            this.category = category;
        }

        public string Category { get { return category; } }
    } 
}