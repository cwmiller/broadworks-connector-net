using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Choices for the Performance Measurement Reporting encoding.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum PerformanceMeasurementReportingEncoding
    {
        [XmlEnum(Name = "US-ACSII")]
        USACSII,
        [XmlEnum(Name = "ISO-8859-1")]
        ISO88591,
        [XmlEnum(Name = "UTF-8")]
        UTF8,
    }
}
