using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallCenterStatisticsSource
    {
        [XmlEnum(Name = "None")]
        None,
        [XmlEnum(Name = "Application Server")]
        ApplicationServer,
        [XmlEnum(Name = "Call Center Reporting Server")]
        CallCenterReportingServer,
    }
}
