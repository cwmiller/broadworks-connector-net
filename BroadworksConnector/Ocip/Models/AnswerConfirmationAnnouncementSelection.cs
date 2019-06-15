using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Anser Confirmation Announcement Selection.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum AnswerConfirmationAnnouncementSelection    {
            [XmlEnum(Name = "System")]
        System,
            [XmlEnum(Name = "Custom")]
        Custom,
     }
}
