using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Group's policy for department administrator's access to trunk group configuration.
    /// "Full" indicates full access to trunk groups in the department.
    /// "None" indicates no access to trunk groups in the department.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum GroupDepartmentAdminTrunkGroupAccess    {
            [XmlEnum(Name = "Full")]
        Full,
            [XmlEnum(Name = "None")]
        None,
     }
}
