using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum NumberActivationMode{
    [XmlEnum(Name = "Off")]
    Off,
    [XmlEnum(Name = "User Activation Enabled")]
    UserActivationEnabled,
    [XmlEnum(Name = "Group And User Activation Enabled")]
    GroupAndUserActivationEnabled,
 }
}
