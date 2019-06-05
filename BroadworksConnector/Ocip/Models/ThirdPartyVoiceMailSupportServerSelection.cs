using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum ThirdPartyVoiceMailSupportServerSelection{
    [XmlEnum(Name = "Group Mail Server")]
    GroupMailServer,
    [XmlEnum(Name = "User Specific Mail Server")]
    UserSpecificMailServer,
 }
}
