using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
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
