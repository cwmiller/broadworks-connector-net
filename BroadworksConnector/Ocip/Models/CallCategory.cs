using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The Call Category for the call provided in the most significant contact from the NS
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallCategory
    {
        [XmlEnum(Name = "Local")]
        Local,
        [XmlEnum(Name = "National")]
        National,
        [XmlEnum(Name = "Interlata")]
        Interlata,
        [XmlEnum(Name = "Intralata")]
        Intralata,
        [XmlEnum(Name = "International")]
        International,
        [XmlEnum(Name = "Private")]
        Private,
        [XmlEnum(Name = "Emergency")]
        Emergency,
        [XmlEnum(Name = "Other")]
        Other,
    }
}
