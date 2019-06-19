using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// IMS User State per the 3GPP TS 29.328 V6.3.0 spec.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum IMSUserState
    {
        [XmlEnum(Name = "Not Registered")]
        NotRegistered,
        [XmlEnum(Name = "Registered")]
        Registered,
        [XmlEnum(Name = "Registered UnReg Services")]
        RegisteredUnRegServices,
        [XmlEnum(Name = "Authentication Pending")]
        AuthenticationPending,
    }
}
