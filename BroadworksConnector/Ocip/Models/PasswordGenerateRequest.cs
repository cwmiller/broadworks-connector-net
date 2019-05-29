using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class PasswordGenerateRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "systemAdministratorPassword", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.PasswordForSystemAdministrator SystemAdministratorPassword { get; set; }
    [XmlElement(ElementName = "serviceProviderAdministratorPassword", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.PasswordForServiceProviderAdministrator ServiceProviderAdministratorPassword { get; set; }
    [XmlElement(ElementName = "groupAdministratorPassword", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.PasswordForGroupAdministrator GroupAdministratorPassword { get; set; }
    [XmlElement(ElementName = "userPassword", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.PasswordForUser UserPassword { get; set; }
    [XmlElement(ElementName = "accessDeviceAuthenticationPassword", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.PasswordForAccessDevice AccessDeviceAuthenticationPassword { get; set; }
    [XmlElement(ElementName = "trunkGroupAuthenticationPassword", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.PasswordForTrunkGroup TrunkGroupAuthenticationPassword { get; set; }
 }
}
