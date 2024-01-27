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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""405ec18fe08719ecf74e749d7e18c88f:205""}]")]
    public class EnterpriseCommunicationBarringAuthorizationCodeGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.EnterpriseCommunicationBarringAuthorizationCodeGetListResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"405ec18fe08719ecf74e749d7e18c88f:205")]
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
        [Group(@"405ec18fe08719ecf74e749d7e18c88f:205")]
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

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaCommunicationBarringAuthorizationCode> _searchCriteriaCommunicationBarringAuthorizationCode = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaCommunicationBarringAuthorizationCode>();

        [XmlElement(ElementName = "searchCriteriaCommunicationBarringAuthorizationCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"405ec18fe08719ecf74e749d7e18c88f:205")]
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
        protected bool SearchCriteriaCommunicationBarringAuthorizationCodeSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaCommunicationBarringAuthorizationCodeDescription> _searchCriteriaCommunicationBarringAuthorizationCodeDescription = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaCommunicationBarringAuthorizationCodeDescription>();

        [XmlElement(ElementName = "searchCriteriaCommunicationBarringAuthorizationCodeDescription", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"405ec18fe08719ecf74e749d7e18c88f:205")]
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
        protected bool SearchCriteriaCommunicationBarringAuthorizationCodeDescriptionSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaNetworkClassOfServiceName> _searchCriteriaNetworkClassOfServiceName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaNetworkClassOfServiceName>();

        [XmlElement(ElementName = "searchCriteriaNetworkClassOfServiceName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"405ec18fe08719ecf74e749d7e18c88f:205")]
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
        protected bool SearchCriteriaNetworkClassOfServiceNameSpecified { get; set; }

    }
}
