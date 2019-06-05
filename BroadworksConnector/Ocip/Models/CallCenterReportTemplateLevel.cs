using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallCenterReportTemplateLevel
    {
        [XmlEnum(Name = "System")]
        System,
        [XmlEnum(Name = "Enterprise")]
        Enterprise,
        [XmlEnum(Name = "Group")]
        Group,
    }
}
