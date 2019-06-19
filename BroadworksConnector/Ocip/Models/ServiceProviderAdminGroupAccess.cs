using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Service Provider Administrator's policy for accessing groups
    /// within the service provider.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum ServiceProviderAdminGroupAccess
    {
        [XmlEnum(Name = "Full")]
        Full,
        [XmlEnum(Name = "Restricted from Adding or Removing Groups")]
        RestrictedfromAddingorRemovingGroups,
        [XmlEnum(Name = "None")]
        None,
    }
}
