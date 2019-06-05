using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum IMSUserState{
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
