using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Call center stranded calls - unavailable routing policy processing action.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallCenterStrandedCallUnavailableProcessingAction
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
