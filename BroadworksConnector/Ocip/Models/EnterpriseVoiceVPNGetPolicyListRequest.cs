using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the list of Voice VPN locations.
    /// It is possible to search by various criteria to restrict the number of rows returned.
    /// Multiple search criteria are logically ANDed together.
    /// The response is either a EnterpriseVoiceVPNGetPolicyListResponse or an ErrorResponse.
    /// <see cref="EnterpriseVoiceVPNGetPolicyListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""405ec18fe08719ecf74e749d7e18c88f:1085""}]")]
    public class EnterpriseVoiceVPNGetPolicyListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.EnterpriseVoiceVPNGetPolicyListResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"405ec18fe08719ecf74e749d7e18c88f:1085")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderIdSpecified { get; set; }

        protected int _responseSizeLimit;

        [XmlElement(ElementName = "responseSizeLimit", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"405ec18fe08719ecf74e749d7e18c88f:1085")]
        [MinInclusive(1)]
        public int ResponseSizeLimit
        {
            get => _responseSizeLimit;
            set
            {
                ResponseSizeLimitSpecified = true;
                _responseSizeLimit = value;
            }
        }

        [XmlIgnore]
        protected bool ResponseSizeLimitSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupLocationCode> _searchCriteriaGroupLocationCode = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupLocationCode>();

        [XmlElement(ElementName = "searchCriteriaGroupLocationCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"405ec18fe08719ecf74e749d7e18c88f:1085")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupLocationCode> SearchCriteriaGroupLocationCode
        {
            get => _searchCriteriaGroupLocationCode;
            set
            {
                SearchCriteriaGroupLocationCodeSpecified = true;
                _searchCriteriaGroupLocationCode = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaGroupLocationCodeSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SearchCriteriaExactPolicySelection _searchCriteriaExactPolicySelection;

        [XmlElement(ElementName = "searchCriteriaExactPolicySelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"405ec18fe08719ecf74e749d7e18c88f:1085")]
        public BroadWorksConnector.Ocip.Models.SearchCriteriaExactPolicySelection SearchCriteriaExactPolicySelection
        {
            get => _searchCriteriaExactPolicySelection;
            set
            {
                SearchCriteriaExactPolicySelectionSpecified = true;
                _searchCriteriaExactPolicySelection = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaExactPolicySelectionSpecified { get; set; }

    }
}
