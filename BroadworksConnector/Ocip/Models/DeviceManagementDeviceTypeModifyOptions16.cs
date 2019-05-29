using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class DeviceManagementDeviceTypeModifyOptions16 
{
    [XmlElement(ElementName = "deviceAccessProtocol", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DeviceAccessProtocol16 DeviceAccessProtocol { get; set; }
    [XmlElement(ElementName = "tagMode", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DeviceManagementTagMode TagMode { get; set; }
    [XmlElement(ElementName = "tagSet", IsNullable = true)]
    public string TagSet { get; set; }
    [XmlElement(ElementName = "allowDeviceProfileCustomTagSet", IsNullable = false)]
    public bool AllowDeviceProfileCustomTagSet { get; set; }
    [XmlElement(ElementName = "allowGroupCustomTagSet", IsNullable = false)]
    public bool AllowGroupCustomTagSet { get; set; }
    [XmlElement(ElementName = "allowSpCustomTagSet", IsNullable = false)]
    public bool AllowSpCustomTagSet { get; set; }
    [XmlElement(ElementName = "sendEmailUponResetFailure", IsNullable = false)]
    public bool SendEmailUponResetFailure { get; set; }
    [XmlElement(ElementName = "deviceAccessNetAddress", IsNullable = true)]
    public string DeviceAccessNetAddress { get; set; }
    [XmlElement(ElementName = "deviceAccessPort", IsNullable = true)]
    public int? DeviceAccessPort { get; set; }
    [XmlElement(ElementName = "deviceAccessContext", IsNullable = true)]
    public string DeviceAccessContext { get; set; }
    [XmlElement(ElementName = "defaultDeviceLanguage", IsNullable = true)]
    public string DefaultDeviceLanguage { get; set; }
    [XmlElement(ElementName = "defaultDeviceEncoding", IsNullable = true)]
    public string DefaultDeviceEncoding { get; set; }
    [XmlElement(ElementName = "accessDeviceCredentials", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.DeviceManagementUserNamePassword16 AccessDeviceCredentials { get; set; }
    [XmlElement(ElementName = "useHttpDigestAuthentication", IsNullable = false)]
    public bool UseHttpDigestAuthentication { get; set; }
    [XmlElement(ElementName = "macBasedFileAuthentication", IsNullable = false)]
    public bool MacBasedFileAuthentication { get; set; }
    [XmlElement(ElementName = "userNamePasswordFileAuthentication", IsNullable = false)]
    public bool UserNamePasswordFileAuthentication { get; set; }
    [XmlElement(ElementName = "macInNonRequestURI", IsNullable = false)]
    public bool MacInNonRequestURI { get; set; }
    [XmlElement(ElementName = "macInCert", IsNullable = false)]
    public bool MacInCert { get; set; }
    [XmlElement(ElementName = "macFormatInNonRequestURI", IsNullable = true)]
    public string MacFormatInNonRequestURI { get; set; }
 }
}
