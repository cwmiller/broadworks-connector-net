using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class EnterpriseVoiceVPNGetPolicyListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
    {
        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
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
        public bool ServiceProviderIdSpecified { get; set; }
        private int _responseSizeLimit;

        [XmlElement(ElementName = "responseSizeLimit", IsNullable = false, Namespace = "")]
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
        public bool ResponseSizeLimitSpecified { get; set; }
        private List<BroadworksConnector.Ocip.Models.SearchCriteriaGroupLocationCode> _searchCriteriaGroupLocationCode;

        [XmlElement(ElementName = "searchCriteriaGroupLocationCode", IsNullable = false, Namespace = "")]
        public List<BroadworksConnector.Ocip.Models.SearchCriteriaGroupLocationCode> SearchCriteriaGroupLocationCode
        {
            get => _searchCriteriaGroupLocationCode;
            set
            {
                SearchCriteriaGroupLocationCodeSpecified = true;
                _searchCriteriaGroupLocationCode = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaGroupLocationCodeSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.SearchCriteriaExactPolicySelection _searchCriteriaExactPolicySelection;

        [XmlElement(ElementName = "searchCriteriaExactPolicySelection", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.SearchCriteriaExactPolicySelection SearchCriteriaExactPolicySelection
        {
            get => _searchCriteriaExactPolicySelection;
            set
            {
                SearchCriteriaExactPolicySelectionSpecified = true;
                _searchCriteriaExactPolicySelection = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaExactPolicySelectionSpecified { get; set; }
    }
}
