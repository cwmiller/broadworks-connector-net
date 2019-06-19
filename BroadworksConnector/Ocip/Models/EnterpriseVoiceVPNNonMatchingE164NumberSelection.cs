using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Enterprise Voice VPN Selector for Non Matching E164 Number.
    /// </summary>
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
