using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum CallCenterReportServerChoice{
    [XmlEnum(Name = "CCRS")]
    CCRS,
    [XmlEnum(Name = "Enhanced")]
    Enhanced,
    [XmlEnum(Name = "Both")]
    Both,
 }
}
