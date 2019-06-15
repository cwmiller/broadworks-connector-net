using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the user level data associated with Call Policies.
    /// The following elements are only used in AS data mode:
    /// callingLineIdentityForRedirectedCalls
    /// 
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserCallPoliciesModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        public string UserId {
            get => _userId;
            set {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        public bool UserIdSpecified { get; set; }
        
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
