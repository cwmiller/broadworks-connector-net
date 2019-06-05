using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CommunicationBarringOriginatingAction
    {
        [XmlEnum(Name = "Allow")]
        Allow,
        [XmlEnum(Name = "Allow Timed")]
        AllowTimed,
        [XmlEnum(Name = "Block")]
        Block,
        [XmlEnum(Name = "Authorization Code")]
        AuthorizationCode,
        [XmlEnum(Name = "Authorization Code Timed")]
        AuthorizationCodeTimed,
        [XmlEnum(Name = "Treatment")]
        Treatment,
        [XmlEnum(Name = "Transfer")]
        Transfer,
    }
}
