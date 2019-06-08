using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum CallCenterReportServerChoice19{
    [XmlEnum(Name = "Enhanced")]
    Enhanced,
    [XmlEnum(Name = "Off")]
    Off,
 }
}
