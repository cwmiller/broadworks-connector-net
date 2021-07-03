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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b009175f2a2a9d38115e319a6ad64d7f:388""}]")]
    public class ResellerCallPoliciesGetResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _forceRedirectingUserIdentityForRedirectedCalls;

        [XmlElement(ElementName = "forceRedirectingUserIdentityForRedirectedCalls", IsNullable = false, Namespace = "")]
        [Group(@"b009175f2a2a9d38115e319a6ad64d7f:388")]
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

        private bool _applyRedirectingUserIdentityToNetworkLocations;

        [XmlElement(ElementName = "applyRedirectingUserIdentityToNetworkLocations", IsNullable = false, Namespace = "")]
        [Group(@"b009175f2a2a9d38115e319a6ad64d7f:388")]
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
