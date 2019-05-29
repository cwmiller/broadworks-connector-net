using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class PasswordForServiceProviderAdministrator 
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "administratorId", IsNullable = false)]
    public string AdministratorId { get; set; }
    [XmlElement(ElementName = "generatePassword", IsNullable = false)]
    public bool GeneratePassword { get; set; }
 }
}
