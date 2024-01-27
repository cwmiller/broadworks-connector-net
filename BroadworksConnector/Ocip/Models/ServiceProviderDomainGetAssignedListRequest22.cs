using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the list of all matching domains assigned to a service provider .
    /// The response is either ServiceProviderDomainGetAssignedListResponse22 or ErrorResponse.
    /// 
    /// The following elements are only used in AS data mode and will be ignored in XS data mode:
    /// responseSizeLimit
    /// searchCriteriaDomainName
    /// searchCriteriaExactDomainLevel
    /// <see cref="ServiceProviderDomainGetAssignedListResponse22"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:4067""}]")]
    public class ServiceProviderDomainGetAssignedListRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.ServiceProviderDomainGetAssignedListResponse22>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:4067")]
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
        [Group(@"e19a9072c2dad499e9f28837da5768db:4067")]
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

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaDomainName> _searchCriteriaDomainName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaDomainName>();

        [XmlElement(ElementName = "searchCriteriaDomainName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:4067")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaDomainName> SearchCriteriaDomainName
        {
            get => _searchCriteriaDomainName;
            set
            {
                SearchCriteriaDomainNameSpecified = true;
                _searchCriteriaDomainName = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaDomainNameSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SearchCriteriaExactDomainLevel _searchCriteriaExactDomainLevel;

        [XmlElement(ElementName = "searchCriteriaExactDomainLevel", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:4067")]
        public BroadWorksConnector.Ocip.Models.SearchCriteriaExactDomainLevel SearchCriteriaExactDomainLevel
        {
            get => _searchCriteriaExactDomainLevel;
            set
            {
                SearchCriteriaExactDomainLevelSpecified = true;
                _searchCriteriaExactDomainLevel = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaExactDomainLevelSpecified { get; set; }

    }
}
