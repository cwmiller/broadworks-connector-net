using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class EnterpriseCallCenterCurrentAndPastAgentGetListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
        private List<BroadworksConnector.Ocip.Models.SearchCriteriaUserLastName> _searchCriteriaUserLastName;

        [XmlElement(ElementName = "searchCriteriaUserLastName", IsNullable = false, Namespace = "")]
        public List<BroadworksConnector.Ocip.Models.SearchCriteriaUserLastName> SearchCriteriaUserLastName
        {
            get => _searchCriteriaUserLastName;
            set
            {
                SearchCriteriaUserLastNameSpecified = true;
                _searchCriteriaUserLastName = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaUserLastNameSpecified { get; set; }
        private List<BroadworksConnector.Ocip.Models.SearchCriteriaUserFirstName> _searchCriteriaUserFirstName;

        [XmlElement(ElementName = "searchCriteriaUserFirstName", IsNullable = false, Namespace = "")]
        public List<BroadworksConnector.Ocip.Models.SearchCriteriaUserFirstName> SearchCriteriaUserFirstName
        {
            get => _searchCriteriaUserFirstName;
            set
            {
                SearchCriteriaUserFirstNameSpecified = true;
                _searchCriteriaUserFirstName = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaUserFirstNameSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.SearchCriteriaExactUserGroup _searchCriteriaExactUserGroup;

        [XmlElement(ElementName = "searchCriteriaExactUserGroup", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.SearchCriteriaExactUserGroup SearchCriteriaExactUserGroup
        {
            get => _searchCriteriaExactUserGroup;
            set
            {
                SearchCriteriaExactUserGroupSpecified = true;
                _searchCriteriaExactUserGroup = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaExactUserGroupSpecified { get; set; }
        private List<BroadworksConnector.Ocip.Models.SearchCriteriaUserId> _searchCriteriaUserId;

        [XmlElement(ElementName = "searchCriteriaUserId", IsNullable = false, Namespace = "")]
        public List<BroadworksConnector.Ocip.Models.SearchCriteriaUserId> SearchCriteriaUserId
        {
            get => _searchCriteriaUserId;
            set
            {
                SearchCriteriaUserIdSpecified = true;
                _searchCriteriaUserId = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaUserIdSpecified { get; set; }
        private List<BroadworksConnector.Ocip.Models.SearchCriteriaDn> _searchCriteriaDn;

        [XmlElement(ElementName = "searchCriteriaDn", IsNullable = false, Namespace = "")]
        public List<BroadworksConnector.Ocip.Models.SearchCriteriaDn> SearchCriteriaDn
        {
            get => _searchCriteriaDn;
            set
            {
                SearchCriteriaDnSpecified = true;
                _searchCriteriaDn = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaDnSpecified { get; set; }
        private List<BroadworksConnector.Ocip.Models.SearchCriteriaExtension> _searchCriteriaExtension;

        [XmlElement(ElementName = "searchCriteriaExtension", IsNullable = false, Namespace = "")]
        public List<BroadworksConnector.Ocip.Models.SearchCriteriaExtension> SearchCriteriaExtension
        {
            get => _searchCriteriaExtension;
            set
            {
                SearchCriteriaExtensionSpecified = true;
                _searchCriteriaExtension = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaExtensionSpecified { get; set; }
    }
}
