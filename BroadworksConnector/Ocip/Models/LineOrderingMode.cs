using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum LineOrderingMode{
    [XmlEnum(Name = "Dynamic")]
    Dynamic,
    [XmlEnum(Name = "Static")]
    Static,
 }
}
