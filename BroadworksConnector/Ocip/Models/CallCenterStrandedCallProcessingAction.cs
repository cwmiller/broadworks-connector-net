using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Call center stranded call processing action.
    /// </summary>
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
