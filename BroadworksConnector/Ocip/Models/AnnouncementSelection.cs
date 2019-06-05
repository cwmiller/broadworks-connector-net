using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum AnnouncementSelection
    {
        [XmlEnum(Name = "Default")]
        Default,
        [XmlEnum(Name = "Personal")]
        Personal,
    }
}
