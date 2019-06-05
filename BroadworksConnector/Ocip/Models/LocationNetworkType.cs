using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum LocationNetworkType{
    [XmlEnum(Name = "Fixed")]
    Fixed,
    [XmlEnum(Name = "Mobile")]
    Mobile,
 }
}
