using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Service Provider Administrator's policy for accessing service packs.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum ServiceProviderAdminServicePackAccess    {
            [XmlEnum(Name = "Full")]
        Full,
            [XmlEnum(Name = "None")]
        None,
     }
}
