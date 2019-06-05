using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum HPBXAlternateCarrierType{
    [XmlEnum(Name = "Local And Distant")]
    LocalAndDistant,
    [XmlEnum(Name = "Distant")]
    Distant,
 }
}
