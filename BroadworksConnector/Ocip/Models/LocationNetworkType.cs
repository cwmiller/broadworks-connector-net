using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
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
