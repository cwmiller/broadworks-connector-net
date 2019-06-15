using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Department Administrator's policy for accessing calling line id number.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum GroupDepartmentAdminCallingLineIdNumberAccess    {
            [XmlEnum(Name = "Full")]
        Full,
            [XmlEnum(Name = "Read-Only")]
        ReadOnly,
     }
}
