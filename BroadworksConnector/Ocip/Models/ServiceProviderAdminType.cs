using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Service Provider Administrator type
    /// "Normal" indicates the service provider admin is a normal admin.
    /// "Customer" indicates the service provider admin is a customer admin.
    /// "Password Reset Only" indicates the service provider admin is a password reset only admin.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum ServiceProviderAdminType    {
            [XmlEnum(Name = "Normal")]
        Normal,
            [XmlEnum(Name = "Customer")]
        Customer,
            [XmlEnum(Name = "Password Reset Only")]
        PasswordResetOnly,
     }
}
