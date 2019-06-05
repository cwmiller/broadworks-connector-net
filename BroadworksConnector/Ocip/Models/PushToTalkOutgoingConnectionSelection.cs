using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum PushToTalkOutgoingConnectionSelection{
    [XmlEnum(Name = "One Way")]
    OneWay,
    [XmlEnum(Name = "Two Way")]
    TwoWay,
 }
}
