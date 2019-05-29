using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class LoginRequest14sp4 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "signedPassword", IsNullable = false)]
    public string SignedPassword { get; set; }
    [XmlElement(ElementName = "plainTextPassword", IsNullable = false)]
    public string PlainTextPassword { get; set; }
 }
}
