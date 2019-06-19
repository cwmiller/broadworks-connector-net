using System;
using System.Collections.Generic;
using System.Text;

namespace BroadWorksConnector.Ocip.Validation
{
    /// <summary>
    /// Attribute that indicates that a property isn't required.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    internal class OptionalAttribute : Attribute
    {
    }
}
