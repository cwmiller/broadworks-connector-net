using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Choices for SIP Hold Announcement Method option
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum HoldAnnouncementMethodMode    {
            [XmlEnum(Name = "Inactive")]
        Inactive,
            [XmlEnum(Name = "Bandwidth Attributes")]
        BandwidthAttributes,
     }
}
