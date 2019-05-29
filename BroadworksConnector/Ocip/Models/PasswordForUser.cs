using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class PasswordForUser 
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "generatePassword", IsNullable = false)]
    public bool GeneratePassword { get; set; }
    [XmlElement(ElementName = "generatePasscode", IsNullable = false)]
    public bool GeneratePasscode { get; set; }
    [XmlElement(ElementName = "generateSipPassword", IsNullable = false)]
    public bool GenerateSipPassword { get; set; }
 }
}
