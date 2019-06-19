using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Enterprise Voice VPN Location Selection.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum EnterpriseVoiceVPNPolicySelection
    {
        [XmlEnum(Name = "Private")]
        Private,
        [XmlEnum(Name = "Public")]
        Public,
        [XmlEnum(Name = "Route")]
        Route,
        [XmlEnum(Name = "Treatment")]
        Treatment,
    }
}
