using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class DeviceManagementDeviceTypeOptions21sp1 
{
    [XmlElement(ElementName = "deviceAccessProtocol", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DeviceAccessProtocol16 DeviceAccessProtocol { get; set; }
    [XmlElement(ElementName = "tagMode", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DeviceManagementTagMode TagMode { get; set; }
    [XmlElement(ElementName = "tagSet", IsNullable = false)]
    public string TagSet { get; set; }
    [XmlElement(ElementName = "allowDeviceProfileCustomTagSet", IsNullable = false)]
    public bool AllowDeviceProfileCustomTagSet { get; set; }
    [XmlElement(ElementName = "allowGroupCustomTagSet", IsNullable = false)]
    public bool AllowGroupCustomTagSet { get; set; }
    [XmlElement(ElementName = "sendEmailUponResetFailure", IsNullable = false)]
    public bool SendEmailUponResetFailure { get; set; }
    [XmlElement(ElementName = "deviceAccessNetAddress", IsNullable = false)]
    public string DeviceAccessNetAddress { get; set; }
    [XmlElement(ElementName = "deviceAccessPort", IsNullable = false)]
    public int DeviceAccessPort { get; set; }
    [XmlElement(ElementName = "deviceAccessContext", IsNullable = false)]
    public string DeviceAccessContext { get; set; }
    [XmlElement(ElementName = "deviceAccessURI", IsNullable = false)]
    public string DeviceAccessURI { get; set; }
    [XmlElement(ElementName = "defaultDeviceLanguage", IsNullable = false)]
    public string DefaultDeviceLanguage { get; set; }
    [XmlElement(ElementName = "defaultDeviceEncoding", IsNullable = false)]
    public string DefaultDeviceEncoding { get; set; }
    [XmlElement(ElementName = "accessDeviceCredentials", IsNullable = false)]
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
    [XmlElement(ElementName = "macFormatInNonRequestURI", IsNullable = false)]
    public string MacFormatInNonRequestURI { get; set; }
 }
}
