using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class DeviceManagementFileAuthLocationGetRequest22V2 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "deviceAccessProtocol", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DeviceAccessProtocol22 DeviceAccessProtocol { get; set; }
    [XmlElement(ElementName = "deviceAccessMethod", IsNullable = false)]
    public string DeviceAccessMethod { get; set; }
    [XmlElement(ElementName = "deviceAccessURI", IsNullable = false)]
    public string DeviceAccessURI { get; set; }
    [XmlElement(ElementName = "accessDeviceUserName", IsNullable = false)]
    public string AccessDeviceUserName { get; set; }
    [XmlElement(ElementName = "accessDeviceUserPassword", IsNullable = false)]
    public string AccessDeviceUserPassword { get; set; }
    [XmlElement(ElementName = "deviceToken", IsNullable = false)]
    public string DeviceToken { get; set; }
    [XmlElement(ElementName = "signedPassword", IsNullable = false)]
    public string SignedPassword { get; set; }
    [XmlElement(ElementName = "macAddress", IsNullable = false)]
    public string MacAddress { get; set; }
    [XmlElement(ElementName = "realmName", IsNullable = false)]
    public string RealmName { get; set; }
    [XmlElement(ElementName = "digestHa1Complement", IsNullable = false)]
    public string DigestHa1Complement { get; set; }
    [XmlElement(ElementName = "digestResponse", IsNullable = false)]
    public string DigestResponse { get; set; }
    [XmlElement(ElementName = "fileNameLookup", IsNullable = false)]
    public bool FileNameLookup { get; set; }
    [XmlElement(ElementName = "fileNameOnDisk", IsNullable = false)]
    public string FileNameOnDisk { get; set; }
 }
}
