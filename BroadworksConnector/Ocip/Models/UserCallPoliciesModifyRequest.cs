using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallPoliciesModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "redirectedCallsCOLPPrivacy", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ConnectedLineIdentificationPrivacyOnRedirectedCalls RedirectedCallsCOLPPrivacy { get; set; }
    [XmlElement(ElementName = "callBeingForwardedResponseCallType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallBeingForwardedResponseCallType CallBeingForwardedResponseCallType { get; set; }
    [XmlElement(ElementName = "callingLineIdentityForRedirectedCalls", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallingLineIdentityForRedirectedCalls CallingLineIdentityForRedirectedCalls { get; set; }
 }
}
