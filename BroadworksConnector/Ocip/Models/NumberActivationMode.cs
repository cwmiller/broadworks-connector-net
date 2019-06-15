using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The Number Activation Modes
    /// 
    /// The following values are only used in AS data mode:
    /// Group And User Activation Enabled
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum NumberActivationMode    {
            [XmlEnum(Name = "Off")]
        Off,
            [XmlEnum(Name = "User Activation Enabled")]
        UserActivationEnabled,
            [XmlEnum(Name = "Group And User Activation Enabled")]
        GroupAndUserActivationEnabled,
     }
}
