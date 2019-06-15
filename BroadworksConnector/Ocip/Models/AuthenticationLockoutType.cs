using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Authentication Lockout type for device profile/SIP authentication password rules.  Possible values:
    /// None: No authentication lockout
    /// Temporary: disable authentication with temporary lockout only
    /// Temporary then Permanent: disable authentication with temporary lockout and permanent lockout
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum AuthenticationLockoutType    {
            [XmlEnum(Name = "None")]
        None,
            [XmlEnum(Name = "Temporary")]
        Temporary,
            [XmlEnum(Name = "Temporary Then Permanent")]
        TemporaryThenPermanent,
     }
}
