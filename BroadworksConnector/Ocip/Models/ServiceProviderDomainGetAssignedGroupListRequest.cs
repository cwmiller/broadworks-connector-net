using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests a list of groups within a service provider that have a given domain assigned.
    /// It is possible to search by various criteria to restrict the number of rows returned.
    /// Multiple search criteria are logically ANDed together.
    /// The response is either a ServiceProviderDomainGetAssignedGroupListResponse or an ErrorResponse.
    /// <see cref="ServiceProviderDomainGetAssignedGroupListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:3947""}]")]
    public class ServiceProviderDomainGetAssignedGroupListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.ServiceProviderDomainGetAssignedGroupListResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:3947")]
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

        protected string _domain;

        [XmlElement(ElementName = "domain", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:3947")]
        [MinLength(1)]
        [MaxLength(80)]
        public string Domain
        {
            get => _domain;
            set
            {
                DomainSpecified = true;
                _domain = value;
            }
        }

        [XmlIgnore]
        protected bool DomainSpecified { get; set; }

        protected int _responseSizeLimit;

        [XmlElement(ElementName = "responseSizeLimit", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:3947")]
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

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupId> _searchCriteriaGroupId = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupId>();

        [XmlElement(ElementName = "searchCriteriaGroupId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:3947")]
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
        protected bool SearchCriteriaGroupIdSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupName> _searchCriteriaGroupName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupName>();

        [XmlElement(ElementName = "searchCriteriaGroupName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:3947")]
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
        protected bool SearchCriteriaGroupNameSpecified { get; set; }

    }
}
