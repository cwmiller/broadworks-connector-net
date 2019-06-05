using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum TrunkGroupSIPIdentityForPilotAndProxyTrunkModesPolicy{
    [XmlEnum(Name = "Pilot User")]
    PilotUser,
    [XmlEnum(Name = "User")]
    User,
 }
}
