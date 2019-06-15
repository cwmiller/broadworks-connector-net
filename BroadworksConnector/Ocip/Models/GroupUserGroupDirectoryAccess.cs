using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Group's policy for a user's access to the group or enterprise directory.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum GroupUserGroupDirectoryAccess    {
            [XmlEnum(Name = "Full")]
        Full,
            [XmlEnum(Name = "None")]
        None,
     }
}
