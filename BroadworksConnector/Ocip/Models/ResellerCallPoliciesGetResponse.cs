using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ResellerCallPoliciesGetRequest.
    /// 
    /// Replaced by: ResellerCallPoliciesGetRequest22 in AS data mode.
    /// <see cref="ResellerCallPoliciesGetRequest"/>
    /// <see cref="ResellerCallPoliciesGetRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:4483""}]")]
    public class ResellerCallPoliciesGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _forceRedirectingUserIdentityForRedirectedCalls;

        [XmlElement(ElementName = "forceRedirectingUserIdentityForRedirectedCalls", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:4483")]
        public bool ForceRedirectingUserIdentityForRedirectedCalls
        {
            get => _forceRedirectingUserIdentityForRedirectedCalls;
            set
            {
                ForceRedirectingUserIdentityForRedirectedCallsSpecified = true;
                _forceRedirectingUserIdentityForRedirectedCalls = value;
            }
        }

        [XmlIgnore]
        protected bool ForceRedirectingUserIdentityForRedirectedCallsSpecified { get; set; }

    }
}
