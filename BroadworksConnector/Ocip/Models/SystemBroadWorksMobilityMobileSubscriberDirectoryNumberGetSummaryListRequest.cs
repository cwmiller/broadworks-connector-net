using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request a summary table of all Mobile Subscriber Directory Numbers in a system.
    /// If reseller administrator sends the request, searchCriteriaResellerId is ignored. All the mobile subscriber
    /// directory numbers in the administrator's reseller meeting the search criteria are returned.
    /// The response is either SystemBroadWorksMobilityMobileSubscriberDirectoryNumberGetSummaryListResponse or ErrorResponse.
    /// 
    /// The following data elements are only used in AS data mode:
    /// searchCriteriaResellerId
    /// <see cref="SystemBroadWorksMobilityMobileSubscriberDirectoryNumberGetSummaryListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f7ae3539fd471e995b07dc1bf8836e2d:1206""}]")]
    public class SystemBroadWorksMobilityMobileSubscriberDirectoryNumberGetSummaryListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private int _responseSizeLimit;

        [XmlElement(ElementName = "responseSizeLimit", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1206")]
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

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaMobileSubscriberDirectoryNumber> _searchCriteriaMobileSubscriberDirectoryNumber = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaMobileSubscriberDirectoryNumber>();

        [XmlElement(ElementName = "searchCriteriaMobileSubscriberDirectoryNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1206")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaMobileSubscriberDirectoryNumber> SearchCriteriaMobileSubscriberDirectoryNumber
        {
            get => _searchCriteriaMobileSubscriberDirectoryNumber;
            set
            {
                SearchCriteriaMobileSubscriberDirectoryNumberSpecified = true;
                _searchCriteriaMobileSubscriberDirectoryNumber = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaMobileSubscriberDirectoryNumberSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SearchCriteriaExactMobileNetwork _searchCriteriaExactMobileNetwork;

        [XmlElement(ElementName = "searchCriteriaExactMobileNetwork", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1206")]
        public BroadWorksConnector.Ocip.Models.SearchCriteriaExactMobileNetwork SearchCriteriaExactMobileNetwork
        {
            get => _searchCriteriaExactMobileNetwork;
            set
            {
                SearchCriteriaExactMobileNetworkSpecified = true;
                _searchCriteriaExactMobileNetwork = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaExactMobileNetworkSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaServiceProviderId> _searchCriteriaServiceProviderId = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaServiceProviderId>();

        [XmlElement(ElementName = "searchCriteriaServiceProviderId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1206")]
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
        protected bool SearchCriteriaServiceProviderIdSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SearchCriteriaExactOrganizationType _searchCriteriaExactOrganizationType;

        [XmlElement(ElementName = "searchCriteriaExactOrganizationType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1206")]
        public BroadWorksConnector.Ocip.Models.SearchCriteriaExactOrganizationType SearchCriteriaExactOrganizationType
        {
            get => _searchCriteriaExactOrganizationType;
            set
            {
                SearchCriteriaExactOrganizationTypeSpecified = true;
                _searchCriteriaExactOrganizationType = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaExactOrganizationTypeSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupId> _searchCriteriaGroupId = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupId>();

        [XmlElement(ElementName = "searchCriteriaGroupId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1206")]
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

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserId> _searchCriteriaUserId = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserId>();

        [XmlElement(ElementName = "searchCriteriaUserId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1206")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserId> SearchCriteriaUserId
        {
            get => _searchCriteriaUserId;
            set
            {
                SearchCriteriaUserIdSpecified = true;
                _searchCriteriaUserId = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaUserIdSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserLastName> _searchCriteriaUserLastName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserLastName>();

        [XmlElement(ElementName = "searchCriteriaUserLastName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1206")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserLastName> SearchCriteriaUserLastName
        {
            get => _searchCriteriaUserLastName;
            set
            {
                SearchCriteriaUserLastNameSpecified = true;
                _searchCriteriaUserLastName = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaUserLastNameSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserFirstName> _searchCriteriaUserFirstName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserFirstName>();

        [XmlElement(ElementName = "searchCriteriaUserFirstName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1206")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserFirstName> SearchCriteriaUserFirstName
        {
            get => _searchCriteriaUserFirstName;
            set
            {
                SearchCriteriaUserFirstNameSpecified = true;
                _searchCriteriaUserFirstName = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaUserFirstNameSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaDn> _searchCriteriaDn = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaDn>();

        [XmlElement(ElementName = "searchCriteriaDn", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1206")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaDn> SearchCriteriaDn
        {
            get => _searchCriteriaDn;
            set
            {
                SearchCriteriaDnSpecified = true;
                _searchCriteriaDn = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaDnSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaExtension> _searchCriteriaExtension = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaExtension>();

        [XmlElement(ElementName = "searchCriteriaExtension", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1206")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaExtension> SearchCriteriaExtension
        {
            get => _searchCriteriaExtension;
            set
            {
                SearchCriteriaExtensionSpecified = true;
                _searchCriteriaExtension = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaExtensionSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaResellerId> _searchCriteriaResellerId = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaResellerId>();

        [XmlElement(ElementName = "searchCriteriaResellerId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:1206")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaResellerId> SearchCriteriaResellerId
        {
            get => _searchCriteriaResellerId;
            set
            {
                SearchCriteriaResellerIdSpecified = true;
                _searchCriteriaResellerId = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaResellerIdSpecified { get; set; }

    }
}
