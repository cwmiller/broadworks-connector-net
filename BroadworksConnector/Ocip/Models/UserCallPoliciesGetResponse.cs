using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallPoliciesGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
}
}
