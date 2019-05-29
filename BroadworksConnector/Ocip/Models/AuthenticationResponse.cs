using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class AuthenticationResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "nonce", IsNullable = false)]
    public string Nonce { get; set; }
    [XmlElement(ElementName = "passwordAlgorithm", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DigitalSignatureAlgorithm PasswordAlgorithm { get; set; }
 }
}
