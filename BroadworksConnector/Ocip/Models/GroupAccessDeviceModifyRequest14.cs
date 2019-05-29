using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupAccessDeviceModifyRequest14 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "deviceName", IsNullable = false)]
    public string DeviceName { get; set; }
    [XmlElement(ElementName = "protocol", IsNullable = false)]
    public string Protocol { get; set; }
    [XmlElement(ElementName = "netAddress", IsNullable = true)]
    public string NetAddress { get; set; }
    [XmlElement(ElementName = "port", IsNullable = true)]
    public int? Port { get; set; }
    [XmlElement(ElementName = "outboundProxyServerNetAddress", IsNullable = true)]
    public string OutboundProxyServerNetAddress { get; set; }
    [XmlElement(ElementName = "stunServerNetAddress", IsNullable = true)]
    public string StunServerNetAddress { get; set; }
    [XmlElement(ElementName = "macAddress", IsNullable = true)]
    public string MacAddress { get; set; }
    [XmlElement(ElementName = "serialNumber", IsNullable = true)]
    public string SerialNumber { get; set; }
    [XmlElement(ElementName = "description", IsNullable = true)]
    public string Description { get; set; }
    [XmlElement(ElementName = "configurationMode", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.AccessDeviceEnhancedConfigurationMode? ConfigurationMode { get; set; }
    [XmlElement(ElementName = "configurationFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.FileResource ConfigurationFile { get; set; }
    [XmlElement(ElementName = "physicalLocation", IsNullable = true)]
    public string PhysicalLocation { get; set; }
    [XmlElement(ElementName = "transportProtocol", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TransportProtocol TransportProtocol { get; set; }
    [XmlElement(ElementName = "mobilityManagerProvisioningURL", IsNullable = false)]
    public string MobilityManagerProvisioningURL { get; set; }
    [XmlElement(ElementName = "mobilityManagerProvisioningUserName", IsNullable = false)]
    public string MobilityManagerProvisioningUserName { get; set; }
    [XmlElement(ElementName = "mobilityManagerProvisioningPassword", IsNullable = false)]
    public string MobilityManagerProvisioningPassword { get; set; }
    [XmlElement(ElementName = "mobilityManagerDefaultOriginatingServiceKey", IsNullable = true)]
    public int? MobilityManagerDefaultOriginatingServiceKey { get; set; }
    [XmlElement(ElementName = "mobilityManagerDefaultTerminatingServiceKey", IsNullable = true)]
    public int? MobilityManagerDefaultTerminatingServiceKey { get; set; }
    [XmlElement(ElementName = "useCustomUserNamePassword", IsNullable = false)]
    public bool UseCustomUserNamePassword { get; set; }
    [XmlElement(ElementName = "accessDeviceCredentials", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.DeviceManagementUserNamePassword16 AccessDeviceCredentials { get; set; }
 }
}
