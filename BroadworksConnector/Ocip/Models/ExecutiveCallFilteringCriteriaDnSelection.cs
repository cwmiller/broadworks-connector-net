using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Eecutive call filtering criteria selection for a dn.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum ExecutiveCallFilteringCriteriaDnSelection
    {
        [XmlEnum(Name = "Any")]
        Any,
        [XmlEnum(Name = "Any Internal")]
        AnyInternal,
        [XmlEnum(Name = "Any External")]
        AnyExternal,
        [XmlEnum(Name = "Specified Only")]
        SpecifiedOnly,
    }
}
