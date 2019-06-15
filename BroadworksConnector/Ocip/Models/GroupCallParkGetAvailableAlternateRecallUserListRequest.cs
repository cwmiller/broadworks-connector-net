using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list of hunt groups that are available to select as an alternate recall user.
    /// The response is either GroupCallParkGetAvailableAlternateRecallUserListResponse or ErrorResponse.
        /// <see cref="GroupCallParkGetAvailableAlternateRecallUserListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupCallParkGetAvailableAlternateRecallUserListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        public string GroupId {
            get => _groupId;
            set {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        public bool GroupIdSpecified { get; set; }
        
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
        
        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserLastName> _searchCriteriaUserLastName;

        [XmlElement(ElementName = "searchCriteriaUserLastName", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserLastName> SearchCriteriaUserLastName {
            get => _searchCriteriaUserLastName;
            set {
                SearchCriteriaUserLastNameSpecified = true;
                _searchCriteriaUserLastName = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaUserLastNameSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserFirstName> _searchCriteriaUserFirstName;

        [XmlElement(ElementName = "searchCriteriaUserFirstName", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserFirstName> SearchCriteriaUserFirstName {
            get => _searchCriteriaUserFirstName;
            set {
                SearchCriteriaUserFirstNameSpecified = true;
                _searchCriteriaUserFirstName = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaUserFirstNameSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.SearchCriteriaExactUserDepartment _searchCriteriaExactUserDepartment;

        [XmlElement(ElementName = "searchCriteriaExactUserDepartment", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SearchCriteriaExactUserDepartment SearchCriteriaExactUserDepartment {
            get => _searchCriteriaExactUserDepartment;
            set {
                SearchCriteriaExactUserDepartmentSpecified = true;
                _searchCriteriaExactUserDepartment = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaExactUserDepartmentSpecified { get; set; }
        
    }
}
