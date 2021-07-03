using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models.C
{
    /// <summary>
    /// The role of the authenticated external user.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "C")]
    public enum ExternalUserIdentityRole
    {
        [XmlEnum(Name = "User")]
        User,
        [XmlEnum(Name = "Administrator")]
        Administrator,
    }
}
