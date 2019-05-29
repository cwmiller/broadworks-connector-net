using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserVoiceMessagingUserModifyVoicePortalPasswordRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "oldPassword", IsNullable = false)]
    public string OldPassword { get; set; }
    [XmlElement(ElementName = "newPassword", IsNullable = false)]
    public string NewPassword { get; set; }
 }
}
