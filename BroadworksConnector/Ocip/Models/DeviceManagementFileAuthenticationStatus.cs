using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum DeviceManagementFileAuthenticationStatus
    {
        [XmlEnum(Name = "Challenge")]
        Challenge,
        [XmlEnum(Name = "Need Digest Authentication")]
        NeedDigestAuthentication,
        [XmlEnum(Name = "Need User Password Authentication")]
        NeedUserPasswordAuthentication,
    }
}
