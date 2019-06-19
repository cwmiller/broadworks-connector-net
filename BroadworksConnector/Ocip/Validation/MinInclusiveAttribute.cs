using System;

namespace BroadWorksConnector.Ocip.Validation
{
    /// <summary>
    /// Attribute for specifying the minimum value allowed for the property
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    internal class MinInclusiveAttribute : Attribute
    {
        public int Minimum { get; private set; }

        public MinInclusiveAttribute(int minimum)
        {
            Minimum = minimum;
        }
    }
}
