using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum AuthenticationMode22
    {
        [XmlEnum(Name = "Enabled")]
        Enabled,
        [XmlEnum(Name = "Disabled")]
        Disabled,
    }
}
