using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get an enterprise's common phone list.
    /// The response is either a EnterpriseCommonPhoneListGetListResponse or an ErrorResponse.
    /// The search can be done using multiple criterion.
    /// If the searchCriteriaModeOr is present, any result matching any one criteria is included in the results.
    /// Otherwise, only results matching all the search criterion are included in the results.
    /// If no search criteria is specified, all results are returned.
    /// Specifying searchCriteriaModeOr without any search criteria results in an ErrorResponse.
    /// In all cases, if a responseSizeLimit is specified and the number of matching results is more than this limit, then an
    /// ErrorResponse is returned.
    /// <see cref="EnterpriseCommonPhoneListGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""5395c7df0157d44aa22f3351d1a5f3da:456""}]")]
    public class EnterpriseCommonPhoneListGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:456")]
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

        private int _responseSizeLimit;

        [XmlElement(ElementName = "responseSizeLimit", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:456")]
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

        private bool _searchCriteriaModeOr;

        [XmlElement(ElementName = "searchCriteriaModeOr", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:456")]
        public bool SearchCriteriaModeOr
        {
            get => _searchCriteriaModeOr;
            set
            {
                SearchCriteriaModeOrSpecified = true;
                _searchCriteriaModeOr = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaModeOrSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaEnterpriseCommonPhoneListName> _searchCriteriaEnterpriseCommonPhoneListName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaEnterpriseCommonPhoneListName>();

        [XmlElement(ElementName = "searchCriteriaEnterpriseCommonPhoneListName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:456")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaEnterpriseCommonPhoneListName> SearchCriteriaEnterpriseCommonPhoneListName
        {
            get => _searchCriteriaEnterpriseCommonPhoneListName;
            set
            {
                SearchCriteriaEnterpriseCommonPhoneListNameSpecified = true;
                _searchCriteriaEnterpriseCommonPhoneListName = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaEnterpriseCommonPhoneListNameSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaEnterpriseCommonPhoneListNumber> _searchCriteriaEnterpriseCommonPhoneListNumber = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaEnterpriseCommonPhoneListNumber>();

        [XmlElement(ElementName = "searchCriteriaEnterpriseCommonPhoneListNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:456")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaEnterpriseCommonPhoneListNumber> SearchCriteriaEnterpriseCommonPhoneListNumber
        {
            get => _searchCriteriaEnterpriseCommonPhoneListNumber;
            set
            {
                SearchCriteriaEnterpriseCommonPhoneListNumberSpecified = true;
                _searchCriteriaEnterpriseCommonPhoneListNumber = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaEnterpriseCommonPhoneListNumberSpecified { get; set; }

    }
}
