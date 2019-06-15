using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// This data type is applicable only for an Enterprise administrator.
    /// Enterprise Administrator's policy for accessing
    /// the Number Activation information.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum EnterpriseAdminNumberActivationAccess    {
            [XmlEnum(Name = "Full")]
        Full,
            [XmlEnum(Name = "Read-Only")]
        ReadOnly,
            [XmlEnum(Name = "None")]
        None,
     }
}
