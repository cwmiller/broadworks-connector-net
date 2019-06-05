using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum MediaStream{
    [XmlEnum(Name = "Dual")]
    Dual,
    [XmlEnum(Name = "Single")]
    Single,
 }
}
