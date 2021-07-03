using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// DN availability
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum DNValidationStatus
    {
        [XmlEnum(Name = "Available")]
        Available,
        [XmlEnum(Name = "Duplicate")]
        Duplicate,
        [XmlEnum(Name = "Duplicate In List")]
        DuplicateInList,
        [XmlEnum(Name = "Invalid")]
        Invalid,
        [XmlEnum(Name = "Unavailable")]
        Unavailable,
    }
}
