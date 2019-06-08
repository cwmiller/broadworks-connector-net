using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum DeviceManagementFileCategory{
    [XmlEnum(Name = "Static")]
    Static,
    [XmlEnum(Name = "Dynamic Group")]
    DynamicGroup,
    [XmlEnum(Name = "Dynamic Profile")]
    DynamicProfile,
 }
}
