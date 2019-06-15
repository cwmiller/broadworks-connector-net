using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get all the current and past call centers for the enterprise.
    /// The searchCriteriaExactUserGroup does not apply to past call centers.
    /// The response is either EnterpriseCallCenterCurrentAndPastCallCenterGetListResponse or ErrorResponse.
        /// <see cref="EnterpriseCallCenterCurrentAndPastCallCenterGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class EnterpriseCallCenterCurrentAndPastCallCenterGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        public string ServiceProviderId {
            get => _serviceProviderId;
            set {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceProviderIdSpecified { get; set; }
        
        private bool _isPremiumOnly;

        [XmlElement(ElementName = "isPremiumOnly", IsNullable = false, Namespace = "")]
        public bool IsPremiumOnly {
            get => _isPremiumOnly;
            set {
                IsPremiumOnlySpecified = true;
                _isPremiumOnly = value;
            }
        }

        [XmlIgnore]
        public bool IsPremiumOnlySpecified { get; set; }
        
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
        
        private BroadWorksConnector.Ocip.Models.SearchCriteriaExactUserGroup _searchCriteriaExactUserGroup;

        [XmlElement(ElementName = "searchCriteriaExactUserGroup", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SearchCriteriaExactUserGroup SearchCriteriaExactUserGroup {
            get => _searchCriteriaExactUserGroup;
            set {
                SearchCriteriaExactUserGroupSpecified = true;
                _searchCriteriaExactUserGroup = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaExactUserGroupSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.SearchCriteriaCallCenterName _searchCriteriaCallCenterName;

        [XmlElement(ElementName = "searchCriteriaCallCenterName", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SearchCriteriaCallCenterName SearchCriteriaCallCenterName {
            get => _searchCriteriaCallCenterName;
            set {
                SearchCriteriaCallCenterNameSpecified = true;
                _searchCriteriaCallCenterName = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaCallCenterNameSpecified { get; set; }
        
    }
}
