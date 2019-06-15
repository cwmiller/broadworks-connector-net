using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Line ordering task status value.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum LineOrderingTaskStatus    {
            [XmlEnum(Name = "NotStarted")]
        NotStarted,
            [XmlEnum(Name = "Pending")]
        Pending,
            [XmlEnum(Name = "Processing")]
        Processing,
     }
}
