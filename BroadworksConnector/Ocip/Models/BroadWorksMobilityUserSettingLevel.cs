using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// BroadWorks Mobility setting for the user level.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum BroadWorksMobilityUserSettingLevel    {
            [XmlEnum(Name = "Group")]
        Group,
            [XmlEnum(Name = "User")]
        User,
     }
}
