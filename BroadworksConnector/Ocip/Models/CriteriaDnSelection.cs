using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Selection criteria for a dn.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CriteriaDnSelection
    {
        [XmlEnum(Name = "Any")]
        Any,
        [XmlEnum(Name = "Specified Only")]
        SpecifiedOnly,
    }
}
