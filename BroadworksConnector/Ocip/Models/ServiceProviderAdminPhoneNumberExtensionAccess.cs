using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Service Provider Administrator's policy for accessing phone numbers or
    /// extensions.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum ServiceProviderAdminPhoneNumberExtensionAccess    {
            [XmlEnum(Name = "Full")]
        Full,
            [XmlEnum(Name = "Assign To Services and Users")]
        AssignToServicesandUsers,
            [XmlEnum(Name = "Read-Only")]
        ReadOnly,
     }
}
