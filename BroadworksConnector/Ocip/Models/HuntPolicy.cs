using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Policy for distributing calls within a hunt group or call center.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum HuntPolicy
    {
        [XmlEnum(Name = "Circular")]
        Circular,
        [XmlEnum(Name = "Regular")]
        Regular,
        [XmlEnum(Name = "Simultaneous")]
        Simultaneous,
        [XmlEnum(Name = "Uniform")]
        Uniform,
        [XmlEnum(Name = "Weighted")]
        Weighted,
    }
}
