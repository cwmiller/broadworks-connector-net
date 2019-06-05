using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum ConnectedNumberSource
    {
        [XmlEnum(Name = "Configurable CLID")]
        ConfigurableCLID,
        [XmlEnum(Name = "Group")]
        Group,
        [XmlEnum(Name = "User")]
        User,
        [XmlEnum(Name = "Department")]
        Department,
    }
}
