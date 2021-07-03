using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get usage of specific policy profile.
    /// The response is either a SystemXsiPolicyProfileGetAssignedServiceProviderListResponse or an ErrorResponse.
    /// <see cref="SystemXsiPolicyProfileGetAssignedServiceProviderListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:19471""}]")]
    public class SystemXsiPolicyProfileGetAssignedServiceProviderListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private BroadWorksConnector.Ocip.Models.XsiPolicyProfileKey _xsiPolicyProfile;

        [XmlElement(ElementName = "xsiPolicyProfile", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:19471")]
        public BroadWorksConnector.Ocip.Models.XsiPolicyProfileKey XsiPolicyProfile
        {
            get => _xsiPolicyProfile;
            set
            {
                XsiPolicyProfileSpecified = true;
                _xsiPolicyProfile = value;
            }
        }

        [XmlIgnore]
        protected bool XsiPolicyProfileSpecified { get; set; }

        private int _responseSizeLimit;

        [XmlElement(ElementName = "responseSizeLimit", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:19471")]
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

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaServiceProviderId> _searchCriteriaServiceProviderId = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaServiceProviderId>();

        [XmlElement(ElementName = "searchCriteriaServiceProviderId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:19471")]
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

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaServiceProviderName> _searchCriteriaServiceProviderName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaServiceProviderName>();

        [XmlElement(ElementName = "searchCriteriaServiceProviderName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:19471")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaServiceProviderName> SearchCriteriaServiceProviderName
        {
            get => _searchCriteriaServiceProviderName;
            set
            {
                SearchCriteriaServiceProviderNameSpecified = true;
                _searchCriteriaServiceProviderName = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaServiceProviderNameSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SearchCriteriaExactOrganizationType _searchCriteriaExactOrganizationType;

        [XmlElement(ElementName = "searchCriteriaExactOrganizationType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:19471")]
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

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaResellerId> _searchCriteriaResellerId = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaResellerId>();

        [XmlElement(ElementName = "searchCriteriaResellerId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:19471")]
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
