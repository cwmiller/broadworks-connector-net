using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Selection criteria for a from dn.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum PriorityAlertCriteriaFromDnSelection    {
            [XmlEnum(Name = "Any External")]
        AnyExternal,
            [XmlEnum(Name = "Specified Only")]
        SpecifiedOnly,
     }
}
