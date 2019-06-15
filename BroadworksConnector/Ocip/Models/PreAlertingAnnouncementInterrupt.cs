using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Pre-alerting Announcement interrupt type.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum PreAlertingAnnouncementInterrupt    {
            [XmlEnum(Name = "Not Allowed")]
        NotAllowed,
            [XmlEnum(Name = "Any Digit")]
        AnyDigit,
            [XmlEnum(Name = "Digit Sequence")]
        DigitSequence,
     }
}
