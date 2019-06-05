using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class EnterpriseCommunicationBarringAuthorizationCodeGetListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
        private List<BroadworksConnector.Ocip.Models.SearchCriteriaCommunicationBarringAuthorizationCode> _searchCriteriaCommunicationBarringAuthorizationCode;

        [XmlElement(ElementName = "searchCriteriaCommunicationBarringAuthorizationCode", IsNullable = false, Namespace = "")]
        public List<BroadworksConnector.Ocip.Models.SearchCriteriaCommunicationBarringAuthorizationCode> SearchCriteriaCommunicationBarringAuthorizationCode
        {
            get => _searchCriteriaCommunicationBarringAuthorizationCode;
            set
            {
                SearchCriteriaCommunicationBarringAuthorizationCodeSpecified = true;
                _searchCriteriaCommunicationBarringAuthorizationCode = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaCommunicationBarringAuthorizationCodeSpecified { get; set; }
        private List<BroadworksConnector.Ocip.Models.SearchCriteriaCommunicationBarringAuthorizationCodeDescription> _searchCriteriaCommunicationBarringAuthorizationCodeDescription;

        [XmlElement(ElementName = "searchCriteriaCommunicationBarringAuthorizationCodeDescription", IsNullable = false, Namespace = "")]
        public List<BroadworksConnector.Ocip.Models.SearchCriteriaCommunicationBarringAuthorizationCodeDescription> SearchCriteriaCommunicationBarringAuthorizationCodeDescription
        {
            get => _searchCriteriaCommunicationBarringAuthorizationCodeDescription;
            set
            {
                SearchCriteriaCommunicationBarringAuthorizationCodeDescriptionSpecified = true;
                _searchCriteriaCommunicationBarringAuthorizationCodeDescription = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaCommunicationBarringAuthorizationCodeDescriptionSpecified { get; set; }
        private List<BroadworksConnector.Ocip.Models.SearchCriteriaNetworkClassOfServiceName> _searchCriteriaNetworkClassOfServiceName;

        [XmlElement(ElementName = "searchCriteriaNetworkClassOfServiceName", IsNullable = false, Namespace = "")]
        public List<BroadworksConnector.Ocip.Models.SearchCriteriaNetworkClassOfServiceName> SearchCriteriaNetworkClassOfServiceName
        {
            get => _searchCriteriaNetworkClassOfServiceName;
            set
            {
                SearchCriteriaNetworkClassOfServiceNameSpecified = true;
                _searchCriteriaNetworkClassOfServiceName = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaNetworkClassOfServiceNameSpecified { get; set; }
    }
}
