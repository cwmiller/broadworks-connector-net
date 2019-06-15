using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserCallPoliciesGetRequest19sp1.
        /// <see cref="UserCallPoliciesGetRequest19sp1"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserCallPoliciesGetResponse19sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
        
        private BroadWorksConnector.Ocip.Models.CallingLineIdentityForRedirectedCalls _callingLineIdentityForRedirectedCalls;

        [XmlElement(ElementName = "callingLineIdentityForRedirectedCalls", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CallingLineIdentityForRedirectedCalls CallingLineIdentityForRedirectedCalls {
            get => _callingLineIdentityForRedirectedCalls;
            set {
                CallingLineIdentityForRedirectedCallsSpecified = true;
                _callingLineIdentityForRedirectedCalls = value;
            }
        }

        [XmlIgnore]
        public bool CallingLineIdentityForRedirectedCallsSpecified { get; set; }
        
    }
}
