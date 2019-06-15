using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Choices for the user device policy line mode.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum UserDevicePolicyLineMode    {
            [XmlEnum(Name = "Single User Private and Shared")]
        SingleUserPrivateandShared,
            [XmlEnum(Name = "Multiple User Shared")]
        MultipleUserShared,
     }
}
