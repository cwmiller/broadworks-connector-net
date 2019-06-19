using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Call center enhanced reporting report file format.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallCenterReportFileFormat
    {
        [XmlEnum(Name = "PDF")]
        PDF,
        [XmlEnum(Name = "XLS")]
        XLS,
    }
}
