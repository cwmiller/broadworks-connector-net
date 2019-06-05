using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum ExternalCustomRingbackSettingLevel
    {
        [XmlEnum(Name = "Service Provider")]
        ServiceProvider,
        [XmlEnum(Name = "User")]
        User,
    }
}
