using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ExternalAuthenticationAuthorizeTokenRequest22 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "password", IsNullable = false)]
    public string Password { get; set; }
    [XmlElement(ElementName = "isPasswordHashed", IsNullable = false)]
    public bool IsPasswordHashed { get; set; }
    [XmlElement(ElementName = "loginToken", IsNullable = false)]
    public string LoginToken { get; set; }
 }
}
