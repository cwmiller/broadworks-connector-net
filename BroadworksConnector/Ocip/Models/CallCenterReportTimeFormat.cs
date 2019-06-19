using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Time format for a call center enhanced reporting report.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallCenterReportTimeFormat
    {
        [XmlEnum(Name = "AM/PM")]
        AMPM,
        [XmlEnum(Name = "24Hour")]
        _24Hour,
    }
}
