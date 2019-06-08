using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
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
