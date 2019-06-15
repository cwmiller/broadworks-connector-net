using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Choices for the group passcode rule to decide which type of rules to use.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum GroupPasscodeRulesLevel    {
            [XmlEnum(Name = "System")]
        System,
            [XmlEnum(Name = "Service Provider")]
        ServiceProvider,
            [XmlEnum(Name = "Group")]
        Group,
     }
}
