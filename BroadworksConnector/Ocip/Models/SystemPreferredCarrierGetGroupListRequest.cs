using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests a list of groups using the specified carrier.  It is possible to restrict the
    /// number of rows returned by specifying various search criteria. Multiple search criteria
    /// are logically ANDed together.
    /// The response is either a SystemPreferredCarrierGetGroupListResponse or an ErrorResponse.
    /// <see cref="SystemPreferredCarrierGetGroupListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""74a46a9bfccb54713c1d19735843f1df:359""}]")]
    public class SystemPreferredCarrierGetGroupListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _carrier;

        [XmlElement(ElementName = "carrier", IsNullable = false, Namespace = "")]
        [Group(@"74a46a9bfccb54713c1d19735843f1df:359")]
        [MinLength(1)]
        [MaxLength(80)]
        public string Carrier
        {
            get => _carrier;
            set
            {
                CarrierSpecified = true;
                _carrier = value;
            }
        }

        [XmlIgnore]
        public bool CarrierSpecified { get; set; }

        private int _responseSizeLimit;

        [XmlElement(ElementName = "responseSizeLimit", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"74a46a9bfccb54713c1d19735843f1df:359")]
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
        public bool ResponseSizeLimitSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupId> _searchCriteriaGroupId = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupId>();

        [XmlElement(ElementName = "searchCriteriaGroupId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"74a46a9bfccb54713c1d19735843f1df:359")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupId> SearchCriteriaGroupId
        {
            get => _searchCriteriaGroupId;
            set
            {
                SearchCriteriaGroupIdSpecified = true;
                _searchCriteriaGroupId = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaGroupIdSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupName> _searchCriteriaGroupName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupName>();

        [XmlElement(ElementName = "searchCriteriaGroupName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"74a46a9bfccb54713c1d19735843f1df:359")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupName> SearchCriteriaGroupName
        {
            get => _searchCriteriaGroupName;
            set
            {
                SearchCriteriaGroupNameSpecified = true;
                _searchCriteriaGroupName = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaGroupNameSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactServiceProvider> _searchCriteriaExactServiceProvider = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactServiceProvider>();

        [XmlElement(ElementName = "searchCriteriaExactServiceProvider", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"74a46a9bfccb54713c1d19735843f1df:359")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactServiceProvider> SearchCriteriaExactServiceProvider
        {
            get => _searchCriteriaExactServiceProvider;
            set
            {
                SearchCriteriaExactServiceProviderSpecified = true;
                _searchCriteriaExactServiceProvider = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaExactServiceProviderSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaServiceProviderId> _searchCriteriaServiceProviderId = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaServiceProviderId>();

        [XmlElement(ElementName = "searchCriteriaServiceProviderId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"74a46a9bfccb54713c1d19735843f1df:359")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaServiceProviderId> SearchCriteriaServiceProviderId
        {
            get => _searchCriteriaServiceProviderId;
            set
            {
                SearchCriteriaServiceProviderIdSpecified = true;
                _searchCriteriaServiceProviderId = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaServiceProviderIdSpecified { get; set; }

    }
}
