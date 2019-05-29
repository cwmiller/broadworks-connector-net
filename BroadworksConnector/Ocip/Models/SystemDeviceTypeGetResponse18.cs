using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDeviceTypeGetResponse18 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "isObsolete", IsNullable = false)]
    public bool IsObsolete { get; set; }
    [XmlElement(ElementName = "profile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SignalingAddressType Profile { get; set; }
    [XmlElement(ElementName = "webBasedConfigURL", IsNullable = false)]
    public string WebBasedConfigURL { get; set; }
    [XmlElement(ElementName = "staticRegistrationCapable", IsNullable = false)]
    public bool StaticRegistrationCapable { get; set; }
    [XmlElement(ElementName = "cpeDeviceOptions", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CPEDeviceOptionsRead16sp1 CpeDeviceOptions { get; set; }
    [XmlElement(ElementName = "protocolChoice", IsNullable = false)]
    public List<string> ProtocolChoice { get; set; }
    [XmlElement(ElementName = "isIpAddressOptional", IsNullable = false)]
    public bool IsIpAddressOptional { get; set; }
    [XmlElement(ElementName = "useDomain", IsNullable = false)]
    public bool UseDomain { get; set; }
    [XmlElement(ElementName = "isMobilityManagerDevice", IsNullable = false)]
    public bool IsMobilityManagerDevice { get; set; }
    [XmlElement(ElementName = "deviceTypeConfigurationOption", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DeviceTypeConfigurationOptionType DeviceTypeConfigurationOption { get; set; }
 }
}
