using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum DeviceManagementTagMode
    {
        [XmlEnum(Name = "None")]
        None,
        [XmlEnum(Name = "System")]
        System,
        [XmlEnum(Name = "System And Custom")]
        SystemAndCustom,
    }
}
