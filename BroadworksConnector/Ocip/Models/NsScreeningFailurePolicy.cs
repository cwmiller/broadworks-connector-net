using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum NsScreeningFailurePolicy{
    [XmlEnum(Name = "Display Received Caller ID")]
    DisplayReceivedCallerID,
    [XmlEnum(Name = "Restrict Number")]
    RestrictNumber,
    [XmlEnum(Name = "Restrict Name And Number")]
    RestrictNameAndNumber,
 }
}
