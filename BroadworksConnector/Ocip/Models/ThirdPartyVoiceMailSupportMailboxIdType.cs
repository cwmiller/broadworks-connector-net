using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum ThirdPartyVoiceMailSupportMailboxIdType{
    [XmlEnum(Name = "User Or Group Phone Number")]
    UserOrGroupPhoneNumber,
    [XmlEnum(Name = "URL")]
    URL,
 }
}
