using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum OutgoingPinholeDigitPlanCallMeNowPermission{
    [XmlEnum(Name = "Ignore")]
    Ignore,
    [XmlEnum(Name = "Allow")]
    Allow,
 }
}
