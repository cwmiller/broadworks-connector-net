using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// BroadWorks Mobility setting for the group level.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum BroadWorksMobilityGroupSettingLevel    {
            [XmlEnum(Name = "Group")]
        Group,
            [XmlEnum(Name = "ServiceProvider")]
        ServiceProvider,
     }
}
