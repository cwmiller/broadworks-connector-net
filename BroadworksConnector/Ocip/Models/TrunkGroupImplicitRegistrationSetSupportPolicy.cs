using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Trunk Group Implicit Registration Set Support policy.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum TrunkGroupImplicitRegistrationSetSupportPolicy    {
            [XmlEnum(Name = "Enabled")]
        Enabled,
            [XmlEnum(Name = "Disabled")]
        Disabled,
     }
}
