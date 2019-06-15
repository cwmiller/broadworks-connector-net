using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Wait algorithm type for device profile/SIP authentication password rules.  Possible values:
    /// Double: Double the previous lockout time (Starting with 5 minutes)
    /// Fixed: Wait a fixed amount of time
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum AuthenticationLockoutWaitAlgorithmType    {
            [XmlEnum(Name = "Double")]
        Double,
            [XmlEnum(Name = "Fixed")]
        Fixed,
     }
}
