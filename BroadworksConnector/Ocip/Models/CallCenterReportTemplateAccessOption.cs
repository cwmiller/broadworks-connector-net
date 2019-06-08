using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum CallCenterReportTemplateAccessOption{
    [XmlEnum(Name = "Supervisor Only")]
    SupervisorOnly,
    [XmlEnum(Name = "Supervisor and Agent")]
    SupervisorandAgent,
 }
}
