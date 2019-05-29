using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserAuthenticationModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "userName", IsNullable = false)]
    public string UserName { get; set; }
    [XmlElement(ElementName = "newPassword", IsNullable = false)]
    public string NewPassword { get; set; }
    [XmlElement(ElementName = "password", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.UserAuthenticationModifyRequestPassword Password { get; set; }
 }
}
