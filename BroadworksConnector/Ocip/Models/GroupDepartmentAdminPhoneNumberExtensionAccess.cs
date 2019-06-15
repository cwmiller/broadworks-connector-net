using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Policy for a department administrator's access to assigning phone numbers and extensions.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum GroupDepartmentAdminPhoneNumberExtensionAccess    {
            [XmlEnum(Name = "Full")]
        Full,
            [XmlEnum(Name = "Read-Only")]
        ReadOnly,
     }
}
