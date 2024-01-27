using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ResellerCallPoliciesGetRequest22.
    /// <see cref="ResellerCallPoliciesGetRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d45e381d6dbac771631649063122a42e:390""}]")]
    public class ResellerCallPoliciesGetResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _forceRedirectingUserIdentityForRedirectedCalls;

        [XmlElement(ElementName = "forceRedirectingUserIdentityForRedirectedCalls", IsNullable = false, Namespace = "")]
        [Group(@"d45e381d6dbac771631649063122a42e:390")]
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

        protected bool _applyRedirectingUserIdentityToNetworkLocations;

        [XmlElement(ElementName = "applyRedirectingUserIdentityToNetworkLocations", IsNullable = false, Namespace = "")]
        [Group(@"d45e381d6dbac771631649063122a42e:390")]
        public bool ApplyRedirectingUserIdentityToNetworkLocations
        {
            get => _applyRedirectingUserIdentityToNetworkLocations;
            set
            {
                ApplyRedirectingUserIdentityToNetworkLocationsSpecified = true;
                _applyRedirectingUserIdentityToNetworkLocations = value;
            }
        }

        [XmlIgnore]
        protected bool ApplyRedirectingUserIdentityToNetworkLocationsSpecified { get; set; }

    }
}
