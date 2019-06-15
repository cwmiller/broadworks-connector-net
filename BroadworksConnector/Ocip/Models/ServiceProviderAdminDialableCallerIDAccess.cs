using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Policy for accessing the service provider Dialable Caller ID configuration.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum ServiceProviderAdminDialableCallerIDAccess    {
            [XmlEnum(Name = "Full")]
        Full,
            [XmlEnum(Name = "Read-Only")]
        ReadOnly,
            [XmlEnum(Name = "None")]
        None,
     }
}
