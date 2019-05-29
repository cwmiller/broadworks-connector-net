using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CombinedSharedCallAppearanceAccessDeviceMultipleIdentityEndpoint 
{
    [XmlElement(ElementName = "accessDevice", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AccessDevice AccessDevice { get; set; }
    [XmlElement(ElementName = "linePort", IsNullable = false)]
    public string LinePort { get; set; }
    [XmlElement(ElementName = "privateIdentity", IsNullable = false)]
    public string PrivateIdentity { get; set; }
    [XmlElement(ElementName = "contact", IsNullable = false)]
    public string Contact { get; set; }
    [XmlElement(ElementName = "portNumber", IsNullable = false)]
    public int PortNumber { get; set; }
    [XmlElement(ElementName = "isActive", IsNullable = false)]
    public bool IsActive { get; set; }
    [XmlElement(ElementName = "allowOrigination", IsNullable = false)]
    public bool AllowOrigination { get; set; }
    [XmlElement(ElementName = "allowTermination", IsNullable = false)]
    public bool AllowTermination { get; set; }
    [XmlElement(ElementName = "allowVideo", IsNullable = false)]
    public bool AllowVideo { get; set; }
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
    [XmlElement(ElementName = "useCustomUserNamePassword", IsNullable = false)]
    public bool UseCustomUserNamePassword { get; set; }
    [XmlElement(ElementName = "accessDeviceCredentials", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DeviceManagementUserNamePassword16 AccessDeviceCredentials { get; set; }
 }
}
