using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDeviceTypeGetAvailableListResponse22TypeInfo 
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
    [XmlElement(ElementName = "isMobilityManagerDevice", IsNullable = false)]
    public bool IsMobilityManagerDevice { get; set; }
    [XmlElement(ElementName = "deviceConfigurationOption", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DeviceTypeConfigurationOptionType DeviceConfigurationOption { get; set; }
    [XmlElement(ElementName = "staticLineOrdering", IsNullable = false)]
    public bool StaticLineOrdering { get; set; }
    [XmlElement(ElementName = "numberOfPorts", IsNullable = false)]
    public int NumberOfPorts { get; set; }
    [XmlElement(ElementName = "deviceTypeLevel", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DeviceTypeLevel DeviceTypeLevel { get; set; }
 }
}
