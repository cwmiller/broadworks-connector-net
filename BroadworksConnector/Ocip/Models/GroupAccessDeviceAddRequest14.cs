using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupAccessDeviceAddRequest14 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "deviceName", IsNullable = false)]
    public string DeviceName { get; set; }
    [XmlElement(ElementName = "deviceType", IsNullable = false)]
    public string DeviceType { get; set; }
    [XmlElement(ElementName = "protocol", IsNullable = false)]
    public string Protocol { get; set; }
    [XmlElement(ElementName = "netAddress", IsNullable = false)]
    public string NetAddress { get; set; }
    [XmlElement(ElementName = "port", IsNullable = false)]
    public int Port { get; set; }
    [XmlElement(ElementName = "outboundProxyServerNetAddress", IsNullable = false)]
    public string OutboundProxyServerNetAddress { get; set; }
    [XmlElement(ElementName = "stunServerNetAddress", IsNullable = false)]
    public string StunServerNetAddress { get; set; }
    [XmlElement(ElementName = "macAddress", IsNullable = false)]
    public string MacAddress { get; set; }
    [XmlElement(ElementName = "serialNumber", IsNullable = false)]
    public string SerialNumber { get; set; }
    [XmlElement(ElementName = "description", IsNullable = false)]
    public string Description { get; set; }
    [XmlElement(ElementName = "physicalLocation", IsNullable = false)]
    public string PhysicalLocation { get; set; }
    [XmlElement(ElementName = "transportProtocol", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TransportProtocol TransportProtocol { get; set; }
    [XmlElement(ElementName = "mobilityManagerProvisioningURL", IsNullable = false)]
    public string MobilityManagerProvisioningURL { get; set; }
    [XmlElement(ElementName = "mobilityManagerProvisioningUserName", IsNullable = false)]
    public string MobilityManagerProvisioningUserName { get; set; }
    [XmlElement(ElementName = "mobilityManagerProvisioningPassword", IsNullable = false)]
    public string MobilityManagerProvisioningPassword { get; set; }
    [XmlElement(ElementName = "mobilityManagerDefaultOriginatingServiceKey", IsNullable = false)]
    public int MobilityManagerDefaultOriginatingServiceKey { get; set; }
    [XmlElement(ElementName = "mobilityManagerDefaultTerminatingServiceKey", IsNullable = false)]
    public int MobilityManagerDefaultTerminatingServiceKey { get; set; }
    [XmlElement(ElementName = "useCustomUserNamePassword", IsNullable = false)]
    public bool UseCustomUserNamePassword { get; set; }
    [XmlElement(ElementName = "accessDeviceCredentials", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DeviceManagementUserNamePassword16 AccessDeviceCredentials { get; set; }
 }
}
