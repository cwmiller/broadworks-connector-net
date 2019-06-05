using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum PreAlertingAnnouncementInterrupt{
    [XmlEnum(Name = "Not Allowed")]
    NotAllowed,
    [XmlEnum(Name = "Any Digit")]
    AnyDigit,
    [XmlEnum(Name = "Digit Sequence")]
    DigitSequence,
 }
}
