using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum GroupNightForwardingUserServiceActivationMode{
    [XmlEnum(Name = "Use Group")]
    UseGroup,
    [XmlEnum(Name = "On")]
    On,
    [XmlEnum(Name = "Off")]
    Off,
 }
}
