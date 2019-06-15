using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the User Personal Assistant Exclusion Number List information.
    /// The response is either a UserPersonalAssistantExclusionNumberGetListResponse or an ErrorResponse.
        /// <see cref="UserPersonalAssistantExclusionNumberGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserPersonalAssistantExclusionNumberGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        public string UserId {
            get => _userId;
            set {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        public bool UserIdSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaPersonalAssistantExclusionNumber> _searchCriteriaPersonalAssistantExclusionNumber;

        [XmlElement(ElementName = "searchCriteriaPersonalAssistantExclusionNumber", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaPersonalAssistantExclusionNumber> SearchCriteriaPersonalAssistantExclusionNumber {
            get => _searchCriteriaPersonalAssistantExclusionNumber;
            set {
                SearchCriteriaPersonalAssistantExclusionNumberSpecified = true;
                _searchCriteriaPersonalAssistantExclusionNumber = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaPersonalAssistantExclusionNumberSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaPersonalAssistantExclusionNumberDescription> _searchCriteriaPersonalAssistantExclusionNumberDescription;

        [XmlElement(ElementName = "searchCriteriaPersonalAssistantExclusionNumberDescription", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaPersonalAssistantExclusionNumberDescription> SearchCriteriaPersonalAssistantExclusionNumberDescription {
            get => _searchCriteriaPersonalAssistantExclusionNumberDescription;
            set {
                SearchCriteriaPersonalAssistantExclusionNumberDescriptionSpecified = true;
                _searchCriteriaPersonalAssistantExclusionNumberDescription = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaPersonalAssistantExclusionNumberDescriptionSpecified { get; set; }
        
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
        
    }
}
