using System;
using System.Collections.Generic;
using System.Text;

namespace BroadWorksConnector.Ocip.Validation
{
    /// <summary>
    /// Attribute for specifying that a property must be a specific length
    /// </summary>
    internal class LengthAttribute : Attribute
    {
        public int Length { get; private set; }

        public LengthAttribute(int length)
        {
            Length = length;
        }
    }
}
