using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum EnterpriseVoiceVPNNonMatchingE164NumberSelection
    {
        [XmlEnum(Name = "Public")]
        Public,
        [XmlEnum(Name = "Default")]
        Default,
    }
}
