using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// This data type is applicable only for an Enterprise administrator.
    /// It specifies the Enterprise Administrator's policy for accessing network policies (e.g. - VoiceVPN).
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum EnterpriseAdminNetworkPolicyAccess
    {
        [XmlEnum(Name = "Full")]
        Full,
        [XmlEnum(Name = "None")]
        None,
    }
}
