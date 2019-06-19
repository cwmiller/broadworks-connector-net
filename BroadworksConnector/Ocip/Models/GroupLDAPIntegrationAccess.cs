using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Group's policy for accessing LDAP Integration configuration.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum GroupLDAPIntegrationAccess
    {
        [XmlEnum(Name = "Full")]
        Full,
        [XmlEnum(Name = "Read-Only")]
        ReadOnly,
        [XmlEnum(Name = "None")]
        None,
    }
}
