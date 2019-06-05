using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum PushToTalkAccessListSelection{
    [XmlEnum(Name = "Allow Calls From Selected Users")]
    AllowCallsFromSelectedUsers,
    [XmlEnum(Name = "Allow Calls From Everyone Except Selected Users")]
    AllowCallsFromEveryoneExceptSelectedUsers,
 }
}
