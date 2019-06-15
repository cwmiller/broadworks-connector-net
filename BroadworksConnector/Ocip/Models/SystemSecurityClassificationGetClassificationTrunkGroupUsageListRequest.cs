using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list of users that currently have the specified Security Classification assigned.
    /// The response is either SystemSecurityClassificationGetClassificationTrunkGroupUsageListResponse or ErrorResponse.
        /// <see cref="SystemSecurityClassificationGetClassificationTrunkGroupUsageListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemSecurityClassificationGetClassificationTrunkGroupUsageListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _securityClassification;

        [XmlElement(ElementName = "securityClassification", IsNullable = false, Namespace = "")]
        public string SecurityClassification {
            get => _securityClassification;
            set {
                SecurityClassificationSpecified = true;
                _securityClassification = value;
            }
        }

        [XmlIgnore]
        public bool SecurityClassificationSpecified { get; set; }
        
        private int _responseSizeLimit;

        [XmlElement(ElementName = "responseSizeLimit", IsNullable = false, Namespace = "")]
        public int ResponseSizeLimit {
            get => _responseSizeLimit;
            set {
                ResponseSizeLimitSpecified = true;
                _responseSizeLimit = value;
            }
        }

        [XmlIgnore]
        public bool ResponseSizeLimitSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaTrunkGroupName> _searchCriteriaTrunkGroupName;

        [XmlElement(ElementName = "searchCriteriaTrunkGroupName", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaTrunkGroupName> SearchCriteriaTrunkGroupName {
            get => _searchCriteriaTrunkGroupName;
            set {
                SearchCriteriaTrunkGroupNameSpecified = true;
                _searchCriteriaTrunkGroupName = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaTrunkGroupNameSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupId> _searchCriteriaGroupId;

        [XmlElement(ElementName = "searchCriteriaGroupId", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupId> SearchCriteriaGroupId {
            get => _searchCriteriaGroupId;
            set {
                SearchCriteriaGroupIdSpecified = true;
                _searchCriteriaGroupId = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaGroupIdSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaServiceProviderId> _searchCriteriaServiceProviderId;

        [XmlElement(ElementName = "searchCriteriaServiceProviderId", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaServiceProviderId> SearchCriteriaServiceProviderId {
            get => _searchCriteriaServiceProviderId;
            set {
                SearchCriteriaServiceProviderIdSpecified = true;
                _searchCriteriaServiceProviderId = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaServiceProviderIdSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.SearchCriteriaExactOrganizationType _searchCriteriaExactOrganizationType;

        [XmlElement(ElementName = "searchCriteriaExactOrganizationType", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SearchCriteriaExactOrganizationType SearchCriteriaExactOrganizationType {
            get => _searchCriteriaExactOrganizationType;
            set {
                SearchCriteriaExactOrganizationTypeSpecified = true;
                _searchCriteriaExactOrganizationType = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaExactOrganizationTypeSpecified { get; set; }
        
    }
}
