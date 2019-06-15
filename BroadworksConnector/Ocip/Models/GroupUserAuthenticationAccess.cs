using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Group's policy for a user's access to their Authentication service configuration.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum GroupUserAuthenticationAccess    {
            [XmlEnum(Name = "Full")]
        Full,
            [XmlEnum(Name = "None")]
        None,
     }
}
