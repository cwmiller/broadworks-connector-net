using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list of Communication Barring Authorization Codes in an enterprise.
    /// The response is either EnterpriseCommunicationBarringAuthorizationCodeGetListResponse or ErrorResponse.
    /// <see cref="EnterpriseCommunicationBarringAuthorizationCodeGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""5395c7df0157d44aa22f3351d1a5f3da:544""}]")]
    public class EnterpriseCommunicationBarringAuthorizationCodeGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:544")]
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
        public bool ServiceProviderIdSpecified { get; set; }

        private int _responseSizeLimit;

        [XmlElement(ElementName = "responseSizeLimit", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:544")]
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

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaCommunicationBarringAuthorizationCode> _searchCriteriaCommunicationBarringAuthorizationCode = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaCommunicationBarringAuthorizationCode>();

        [XmlElement(ElementName = "searchCriteriaCommunicationBarringAuthorizationCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:544")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaCommunicationBarringAuthorizationCode> SearchCriteriaCommunicationBarringAuthorizationCode
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

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaCommunicationBarringAuthorizationCodeDescription> _searchCriteriaCommunicationBarringAuthorizationCodeDescription = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaCommunicationBarringAuthorizationCodeDescription>();

        [XmlElement(ElementName = "searchCriteriaCommunicationBarringAuthorizationCodeDescription", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:544")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaCommunicationBarringAuthorizationCodeDescription> SearchCriteriaCommunicationBarringAuthorizationCodeDescription
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

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaNetworkClassOfServiceName> _searchCriteriaNetworkClassOfServiceName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaNetworkClassOfServiceName>();

        [XmlElement(ElementName = "searchCriteriaNetworkClassOfServiceName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"5395c7df0157d44aa22f3351d1a5f3da:544")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaNetworkClassOfServiceName> SearchCriteriaNetworkClassOfServiceName
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
