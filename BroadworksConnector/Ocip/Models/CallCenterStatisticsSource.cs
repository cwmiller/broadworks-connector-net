using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The call center statistics source.
    /// </summary>
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
