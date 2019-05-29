using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallPoliciesGetResponse17 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "redirectedCallsCOLPPrivacy", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ConnectedLineIdentificationPrivacyOnRedirectedCalls RedirectedCallsCOLPPrivacy { get; set; }
    [XmlElement(ElementName = "callBeingForwardedResponseCallType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallBeingForwardedResponseCallType CallBeingForwardedResponseCallType { get; set; }
 }
}
