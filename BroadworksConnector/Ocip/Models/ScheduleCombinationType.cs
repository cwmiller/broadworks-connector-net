using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Schedule Combination.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum ScheduleCombinationType
    {
        [XmlEnum(Name = "UNION")]
        UNION,
        [XmlEnum(Name = "INTERSECTION")]
        INTERSECTION,
    }
}
