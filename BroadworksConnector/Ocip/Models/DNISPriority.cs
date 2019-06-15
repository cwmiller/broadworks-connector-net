using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Choices for DNIS priority.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum DNISPriority    {
            [XmlEnum(Name = "0 - Highest")]
        _0Highest,
            [XmlEnum(Name = "1 - High")]
        _1High,
            [XmlEnum(Name = "2 - Medium")]
        _2Medium,
            [XmlEnum(Name = "3 - Low")]
        _3Low,
     }
}
