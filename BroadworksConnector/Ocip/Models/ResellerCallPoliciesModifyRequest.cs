using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the reseller level data associated with Call Policies.
    /// The following elements are only used in AS data mode:
    /// forceRedirectingUserIdentityForRedirectedCalls
    /// applyRedirectingUserIdentityToNetworkLocations
    /// 
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d45e381d6dbac771631649063122a42e:411""}]")]
    public class ResellerCallPoliciesModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _resellerId;

        [XmlElement(ElementName = "resellerId", IsNullable = false, Namespace = "")]
        [Group(@"d45e381d6dbac771631649063122a42e:411")]
        [MinLength(1)]
        [MaxLength(36)]
        public string ResellerId
        {
            get => _resellerId;
            set
            {
                ResellerIdSpecified = true;
                _resellerId = value;
            }
        }

        [XmlIgnore]
        protected bool ResellerIdSpecified { get; set; }

        protected bool _forceRedirectingUserIdentityForRedirectedCalls;

        [XmlElement(ElementName = "forceRedirectingUserIdentityForRedirectedCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d45e381d6dbac771631649063122a42e:411")]
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
        [Optional]
        [Group(@"d45e381d6dbac771631649063122a42e:411")]
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
