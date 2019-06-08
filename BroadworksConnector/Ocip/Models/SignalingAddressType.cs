using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum SignalingAddressType{
    [XmlEnum(Name = "Non-intelligent Device Addressing")]
    NonintelligentDeviceAddressing,
    [XmlEnum(Name = "Non-intelligent Proxy Addressing")]
    NonintelligentProxyAddressing,
    [XmlEnum(Name = "Intelligent Device Addressing")]
    IntelligentDeviceAddressing,
    [XmlEnum(Name = "Intelligent Proxy Addressing")]
    IntelligentProxyAddressing,
 }
}
