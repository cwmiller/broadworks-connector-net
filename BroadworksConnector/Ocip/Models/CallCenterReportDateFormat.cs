using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Date format for a call center enhanced reporting report.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallCenterReportDateFormat    {
            [XmlEnum(Name = "MMDDYYYY")]
        MMDDYYYY,
            [XmlEnum(Name = "DDMMYYYY")]
        DDMMYYYY,
     }
}
