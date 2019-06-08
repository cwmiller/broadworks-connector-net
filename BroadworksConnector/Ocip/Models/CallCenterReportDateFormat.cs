using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum CallCenterReportDateFormat{
    [XmlEnum(Name = "MMDDYYYY")]
    MMDDYYYY,
    [XmlEnum(Name = "DDMMYYYY")]
    DDMMYYYY,
 }
}
