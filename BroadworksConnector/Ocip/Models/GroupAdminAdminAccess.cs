using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Policy for a group administrator's access to group administrators and department administrators.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum GroupAdminAdminAccess
    {
        [XmlEnum(Name = "Full")]
        Full,
        [XmlEnum(Name = "Read-Only")]
        ReadOnly,
        [XmlEnum(Name = "None")]
        None,
    }
}
