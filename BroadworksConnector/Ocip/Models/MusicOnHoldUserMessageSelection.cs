using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Music On Hold User Message Selection.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum MusicOnHoldUserMessageSelection    {
            [XmlEnum(Name = "Group")]
        Group,
            [XmlEnum(Name = "Custom")]
        Custom,
     }
}
