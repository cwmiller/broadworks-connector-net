using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Call center scheduled service (Night Services, Holiday Services, etc.) processing action.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallCenterScheduledServiceAction
    {
        [XmlEnum(Name = "None")]
        None,
        [XmlEnum(Name = "Busy")]
        Busy,
        [XmlEnum(Name = "Transfer")]
        Transfer,
    }
}
