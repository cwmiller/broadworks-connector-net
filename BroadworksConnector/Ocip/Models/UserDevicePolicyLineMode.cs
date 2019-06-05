using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum UserDevicePolicyLineMode{
    [XmlEnum(Name = "Single User Private and Shared")]
    SingleUserPrivateandShared,
    [XmlEnum(Name = "Multiple User Shared")]
    MultipleUserShared,
 }
}
