using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class PasswordGenerateResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "systemAdministratorPassword", IsNullable = false)]
    public string SystemAdministratorPassword { get; set; }
    [XmlElement(ElementName = "serviceProviderAdministratorPassword", IsNullable = false)]
    public string ServiceProviderAdministratorPassword { get; set; }
    [XmlElement(ElementName = "groupAdministratorPassword", IsNullable = false)]
    public string GroupAdministratorPassword { get; set; }
    [XmlElement(ElementName = "userPassword", IsNullable = false)]
    public string UserPassword { get; set; }
    [XmlElement(ElementName = "userPasscode", IsNullable = false)]
    public string UserPasscode { get; set; }
    [XmlElement(ElementName = "userSIPAuthenticationPassword", IsNullable = false)]
    public string UserSIPAuthenticationPassword { get; set; }
    [XmlElement(ElementName = "accessDeviceAuthenticationPassword", IsNullable = false)]
    public string AccessDeviceAuthenticationPassword { get; set; }
    [XmlElement(ElementName = "trunkGroupAuthenticationPassword", IsNullable = false)]
    public string TrunkGroupAuthenticationPassword { get; set; }
 }
}
