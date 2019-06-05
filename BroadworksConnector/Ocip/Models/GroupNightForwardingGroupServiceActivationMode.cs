using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum GroupNightForwardingGroupServiceActivationMode{
    [XmlEnum(Name = "Auto On")]
    AutoOn,
    [XmlEnum(Name = "On")]
    On,
    [XmlEnum(Name = "Off")]
    Off,
 }
}
