using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Policy for a group administrator's access to feature access codes.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum GroupAdminFeatureAccessCodeAccess
    {
        [XmlEnum(Name = "Full")]
        Full,
        [XmlEnum(Name = "Read-Only")]
        ReadOnly,
    }
}
