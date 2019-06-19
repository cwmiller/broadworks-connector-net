using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// IMP ID type that determines the IMP ID for Integrated IMP.
    /// "Primary" indicates that the IMP ID is the primary user ID.
    /// "Alternate" indicates that the IMP ID is an alternate user ID.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum IntegratedIMPUserIDType
    {
        [XmlEnum(Name = "Primary")]
        Primary,
        [XmlEnum(Name = "Alternate")]
        Alternate,
    }
}
