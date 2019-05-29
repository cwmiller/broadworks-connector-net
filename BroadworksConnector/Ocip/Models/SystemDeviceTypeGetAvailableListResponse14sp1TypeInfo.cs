using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDeviceTypeGetAvailableListResponse14sp1TypeInfo 
{
    [XmlElement(ElementName = "profile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SignalingAddressType Profile { get; set; }
    [XmlElement(ElementName = "staticRegistrationCapable", IsNullable = false)]
    public bool StaticRegistrationCapable { get; set; }
    [XmlElement(ElementName = "configType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AccessDeviceEnhancedConfigurationType14 ConfigType { get; set; }
    [XmlElement(ElementName = "protocolChoice", IsNullable = false)]
    public List<string> ProtocolChoice { get; set; }
    [XmlElement(ElementName = "isIpAddressOptional", IsNullable = false)]
    public bool IsIpAddressOptional { get; set; }
    [XmlElement(ElementName = "useDomain", IsNullable = false)]
    public bool UseDomain { get; set; }
 }
}
