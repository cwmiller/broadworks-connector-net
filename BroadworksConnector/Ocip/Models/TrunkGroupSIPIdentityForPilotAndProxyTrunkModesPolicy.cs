using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Trunk Group SIP identity for pilot and proxy trunk modes policy.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum TrunkGroupSIPIdentityForPilotAndProxyTrunkModesPolicy
    {
        [XmlEnum(Name = "Pilot User")]
        PilotUser,
        [XmlEnum(Name = "User")]
        User,
    }
}
