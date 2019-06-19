using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Choices for Support Connected Identity Policy
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum TrunkGroupSupportConnectedIdentityPolicy
    {
        [XmlEnum(Name = "Enabled")]
        Enabled,
        [XmlEnum(Name = "Disabled")]
        Disabled,
    }
}
