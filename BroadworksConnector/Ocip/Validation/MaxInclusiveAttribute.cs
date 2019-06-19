using System;

namespace BroadWorksConnector.Ocip.Validation
{
    /// <summary>
    /// Attribute for specifying the maximum value allowed for the property
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    internal class MaxInclusiveAttribute : Attribute
    {
        public int Maximum { get; private set; }

        public MaxInclusiveAttribute(int maximum)
        {
            Maximum = maximum;
        }
    }
}
