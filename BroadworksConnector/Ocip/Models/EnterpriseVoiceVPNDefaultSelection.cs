using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum EnterpriseVoiceVPNDefaultSelection
    {
        [XmlEnum(Name = "Public")]
        Public,
        [XmlEnum(Name = "Private")]
        Private,
    }
}
