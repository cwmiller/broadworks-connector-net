using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserCallPoliciesGetRequest17.
    /// 
    /// Replaced by: UserCallPoliciesGetResponse19sp1 in AS data mode
    /// <see cref="UserCallPoliciesGetRequest17"/>
    /// <see cref="UserCallPoliciesGetResponse19sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:16931""}]")]
    public class UserCallPoliciesGetResponse17 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.ConnectedLineIdentificationPrivacyOnRedirectedCalls _redirectedCallsCOLPPrivacy;

        [XmlElement(ElementName = "redirectedCallsCOLPPrivacy", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:16931")]
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
        [Group(@"240b50f54d060859e5e275082fdf49f9:16931")]
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

    }
}
