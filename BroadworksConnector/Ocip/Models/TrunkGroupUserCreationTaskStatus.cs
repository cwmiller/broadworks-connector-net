using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Trunk Group user creation task status.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum TrunkGroupUserCreationTaskStatus
    {
        [XmlEnum(Name = "Pending")]
        Pending,
        [XmlEnum(Name = "Processing")]
        Processing,
        [XmlEnum(Name = "Completed")]
        Completed,
        [XmlEnum(Name = "Failed")]
        Failed,
    }
}
