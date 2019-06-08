using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum DiameterApplicationId{
    [XmlEnum(Name = "Rf")]
    Rf,
    [XmlEnum(Name = "Ro")]
    Ro,
    [XmlEnum(Name = "Sh")]
    Sh,
 }
}
