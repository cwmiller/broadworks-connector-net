using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserCallPoliciesGetRequest.
    /// <see cref="UserCallPoliciesGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:16958""}]")]
    public class UserCallPoliciesGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.ConnectedLineIdentificationPrivacyOnRedirectedCalls _redirectedCallsCOLPPrivacy;

        [XmlElement(ElementName = "redirectedCallsCOLPPrivacy", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:16958")]
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
        public bool RedirectedCallsCOLPPrivacySpecified { get; set; }

    }
}
