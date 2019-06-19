using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Service Provider Administrator's policy for accessing to Verify Translation and Routing feature.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum ServiceProviderAdminVerifyTranslationAndRoutingAccess
    {
        [XmlEnum(Name = "Full")]
        Full,
        [XmlEnum(Name = "None")]
        None,
    }
}
