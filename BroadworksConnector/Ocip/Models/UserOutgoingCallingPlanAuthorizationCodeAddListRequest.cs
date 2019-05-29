using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserOutgoingCallingPlanAuthorizationCodeAddListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "codeEntry", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.OutgoingCallingPlanAuthorizationCodeEntry> CodeEntry { get; set; }
 }
}
