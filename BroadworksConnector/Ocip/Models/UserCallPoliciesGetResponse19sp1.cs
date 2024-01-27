using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserCallPoliciesGetRequest19sp1.
    /// <see cref="UserCallPoliciesGetRequest19sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:904""}]")]
    public class UserCallPoliciesGetResponse19sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.ConnectedLineIdentificationPrivacyOnRedirectedCalls _redirectedCallsCOLPPrivacy;

        [XmlElement(ElementName = "redirectedCallsCOLPPrivacy", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:904")]
        public BroadWorksConnector.Ocip.Models.ConnectedLineIdentificationPrivacyOnRedirectedCalls RedirectedCallsCOLPPrivacy
        {
            get => _redirectedCallsCOLPPrivacy;
            set
            {
                RedirectedCallsCOLPPrivacySpecified = true;
                _redirectedCallsCOLPPrivacy = value;
            }
        }

        [XmlIgnore]
        protected bool RedirectedCallsCOLPPrivacySpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallBeingForwardedResponseCallType _callBeingForwardedResponseCallType;

        [XmlElement(ElementName = "callBeingForwardedResponseCallType", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:904")]
        public BroadWorksConnector.Ocip.Models.CallBeingForwardedResponseCallType CallBeingForwardedResponseCallType
        {
            get => _callBeingForwardedResponseCallType;
            set
            {
                CallBeingForwardedResponseCallTypeSpecified = true;
                _callBeingForwardedResponseCallType = value;
            }
        }

        [XmlIgnore]
        protected bool CallBeingForwardedResponseCallTypeSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallingLineIdentityForRedirectedCalls _callingLineIdentityForRedirectedCalls;

        [XmlElement(ElementName = "callingLineIdentityForRedirectedCalls", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:904")]
        public BroadWorksConnector.Ocip.Models.CallingLineIdentityForRedirectedCalls CallingLineIdentityForRedirectedCalls
        {
            get => _callingLineIdentityForRedirectedCalls;
            set
            {
                CallingLineIdentityForRedirectedCallsSpecified = true;
                _callingLineIdentityForRedirectedCalls = value;
            }
        }

        [XmlIgnore]
        protected bool CallingLineIdentityForRedirectedCallsSpecified { get; set; }

    }
}
