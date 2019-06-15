using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Music On Hold Message Selection.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum MusicOnHoldMessageSelection    {
            [XmlEnum(Name = "System")]
        System,
            [XmlEnum(Name = "External")]
        External,
            [XmlEnum(Name = "Custom")]
        Custom,
     }
}
