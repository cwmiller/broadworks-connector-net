using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6bd221784ebf8af2fe1169d36a6ac2dd:267""}]")]
    public class UserPersonalAssistantExclusionNumberGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.UserPersonalAssistantExclusionNumberGetListResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"6bd221784ebf8af2fe1169d36a6ac2dd:267")]
        [MinLength(1)]
        [MaxLength(161)]
        public string UserId
        {
            get => _userId;
            set
            {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        protected bool UserIdSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaPersonalAssistantExclusionNumber> _searchCriteriaPersonalAssistantExclusionNumber = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaPersonalAssistantExclusionNumber>();

        [XmlElement(ElementName = "searchCriteriaPersonalAssistantExclusionNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6bd221784ebf8af2fe1169d36a6ac2dd:267")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaPersonalAssistantExclusionNumber> SearchCriteriaPersonalAssistantExclusionNumber
        {
            get => _searchCriteriaPersonalAssistantExclusionNumber;
            set
            {
                SearchCriteriaPersonalAssistantExclusionNumberSpecified = true;
                _searchCriteriaPersonalAssistantExclusionNumber = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaPersonalAssistantExclusionNumberSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaPersonalAssistantExclusionNumberDescription> _searchCriteriaPersonalAssistantExclusionNumberDescription = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaPersonalAssistantExclusionNumberDescription>();

        [XmlElement(ElementName = "searchCriteriaPersonalAssistantExclusionNumberDescription", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6bd221784ebf8af2fe1169d36a6ac2dd:267")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaPersonalAssistantExclusionNumberDescription> SearchCriteriaPersonalAssistantExclusionNumberDescription
        {
            get => _searchCriteriaPersonalAssistantExclusionNumberDescription;
            set
            {
                SearchCriteriaPersonalAssistantExclusionNumberDescriptionSpecified = true;
                _searchCriteriaPersonalAssistantExclusionNumberDescription = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaPersonalAssistantExclusionNumberDescriptionSpecified { get; set; }

        protected int _responseSizeLimit;

        [XmlElement(ElementName = "responseSizeLimit", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6bd221784ebf8af2fe1169d36a6ac2dd:267")]
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

    }
}
