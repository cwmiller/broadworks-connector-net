using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum CallCenterReportTemplateLevel{
    [XmlEnum(Name = "System")]
    System,
    [XmlEnum(Name = "Enterprise")]
    Enterprise,
    [XmlEnum(Name = "Group")]
    Group,
 }
}
