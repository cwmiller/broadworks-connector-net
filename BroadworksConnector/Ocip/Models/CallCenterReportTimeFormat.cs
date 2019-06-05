using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
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
