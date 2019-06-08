using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallPoliciesGetResponse17 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.ConnectedLineIdentificationPrivacyOnRedirectedCalls _redirectedCallsCOLPPrivacy;

    [XmlElement(ElementName = "redirectedCallsCOLPPrivacy", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ConnectedLineIdentificationPrivacyOnRedirectedCalls RedirectedCallsCOLPPrivacy {
        get => _redirectedCallsCOLPPrivacy;
        set {
            RedirectedCallsCOLPPrivacySpecified = true;
            _redirectedCallsCOLPPrivacy = value;
        }
    }

    [XmlIgnore]
    public bool RedirectedCallsCOLPPrivacySpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.CallBeingForwardedResponseCallType _callBeingForwardedResponseCallType;

    [XmlElement(ElementName = "callBeingForwardedResponseCallType", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CallBeingForwardedResponseCallType CallBeingForwardedResponseCallType {
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
