using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Policy for user to delete call logs
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum GroupUserCallLogAccess    {
            [XmlEnum(Name = "Full")]
        Full,
            [XmlEnum(Name = "Read-Only")]
        ReadOnly,
     }
}
