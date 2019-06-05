using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallCenterStatisticsSource17sp1
    {
        [XmlEnum(Name = "None")]
        None,
        [XmlEnum(Name = "Application Server")]
        ApplicationServer,
        [XmlEnum(Name = "External Reporting Server")]
        ExternalReportingServer,
    }
}
