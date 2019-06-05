using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallCenterStrandedCallProcessingAction
    {
        [XmlEnum(Name = "None")]
        None,
        [XmlEnum(Name = "Busy")]
        Busy,
        [XmlEnum(Name = "Transfer")]
        Transfer,
        [XmlEnum(Name = "Night Service")]
        NightService,
        [XmlEnum(Name = "Ringing")]
        Ringing,
        [XmlEnum(Name = "Announcement")]
        Announcement,
    }
}
