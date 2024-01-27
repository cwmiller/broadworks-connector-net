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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:5070""}]")]
    public class ResellerCallPoliciesGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _forceRedirectingUserIdentityForRedirectedCalls;

        [XmlElement(ElementName = "forceRedirectingUserIdentityForRedirectedCalls", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:5070")]
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
