using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallPoliciesGetResponse17 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.ConnectedLineIdentificationPrivacyOnRedirectedCalls _redirectedCallsCOLPPrivacy;

    [XmlElement(ElementName = "redirectedCallsCOLPPrivacy", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ConnectedLineIdentificationPrivacyOnRedirectedCalls RedirectedCallsCOLPPrivacy {
        get => _redirectedCallsCOLPPrivacy;
        set {
            RedirectedCallsCOLPPrivacySpecified = true;
            _redirectedCallsCOLPPrivacy = value;
        }
    }

    [XmlIgnore]
    public bool RedirectedCallsCOLPPrivacySpecified { get; set; }
    private BroadworksConnector.Ocip.Models.CallBeingForwardedResponseCallType _callBeingForwardedResponseCallType;

    [XmlElement(ElementName = "callBeingForwardedResponseCallType", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CallBeingForwardedResponseCallType CallBeingForwardedResponseCallType {
        get => _callBeingForwardedResponseCallType;
        set {
            CallBeingForwardedResponseCallTypeSpecified = true;
            _callBeingForwardedResponseCallType = value;
        }
    }

    [XmlIgnore]
    public bool CallBeingForwardedResponseCallTypeSpecified { get; set; }
}
}
