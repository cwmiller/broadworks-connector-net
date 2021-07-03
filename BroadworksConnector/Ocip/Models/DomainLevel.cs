using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Identifies if a domain is a system level domain or a reseller level domain.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum DomainLevel
    {
        [XmlEnum(Name = "System")]
        System,
        [XmlEnum(Name = "Reseller")]
        Reseller,
    }
}
