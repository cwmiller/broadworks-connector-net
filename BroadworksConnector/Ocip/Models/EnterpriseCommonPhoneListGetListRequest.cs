using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class EnterpriseCommonPhoneListGetListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
        private bool _searchCriteriaModeOr;

        [XmlElement(ElementName = "searchCriteriaModeOr", IsNullable = false, Namespace = "")]
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
        public bool SearchCriteriaModeOrSpecified { get; set; }
        private List<BroadworksConnector.Ocip.Models.SearchCriteriaEnterpriseCommonPhoneListName> _searchCriteriaEnterpriseCommonPhoneListName;

        [XmlElement(ElementName = "searchCriteriaEnterpriseCommonPhoneListName", IsNullable = false, Namespace = "")]
        public List<BroadworksConnector.Ocip.Models.SearchCriteriaEnterpriseCommonPhoneListName> SearchCriteriaEnterpriseCommonPhoneListName
        {
            get => _searchCriteriaEnterpriseCommonPhoneListName;
            set
            {
                SearchCriteriaEnterpriseCommonPhoneListNameSpecified = true;
                _searchCriteriaEnterpriseCommonPhoneListName = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaEnterpriseCommonPhoneListNameSpecified { get; set; }
        private List<BroadworksConnector.Ocip.Models.SearchCriteriaEnterpriseCommonPhoneListNumber> _searchCriteriaEnterpriseCommonPhoneListNumber;

        [XmlElement(ElementName = "searchCriteriaEnterpriseCommonPhoneListNumber", IsNullable = false, Namespace = "")]
        public List<BroadworksConnector.Ocip.Models.SearchCriteriaEnterpriseCommonPhoneListNumber> SearchCriteriaEnterpriseCommonPhoneListNumber
        {
            get => _searchCriteriaEnterpriseCommonPhoneListNumber;
            set
            {
                SearchCriteriaEnterpriseCommonPhoneListNumberSpecified = true;
                _searchCriteriaEnterpriseCommonPhoneListNumber = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaEnterpriseCommonPhoneListNumberSpecified { get; set; }
    }
}
