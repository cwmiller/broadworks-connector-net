using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserPersonalAssistantExclusionNumberGetListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaPersonalAssistantExclusionNumber> _searchCriteriaPersonalAssistantExclusionNumber;

    [XmlElement(ElementName = "searchCriteriaPersonalAssistantExclusionNumber", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaPersonalAssistantExclusionNumber> SearchCriteriaPersonalAssistantExclusionNumber {
        get => _searchCriteriaPersonalAssistantExclusionNumber;
        set {
            SearchCriteriaPersonalAssistantExclusionNumberSpecified = true;
            _searchCriteriaPersonalAssistantExclusionNumber = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaPersonalAssistantExclusionNumberSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaPersonalAssistantExclusionNumberDescription> _searchCriteriaPersonalAssistantExclusionNumberDescription;

    [XmlElement(ElementName = "searchCriteriaPersonalAssistantExclusionNumberDescription", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaPersonalAssistantExclusionNumberDescription> SearchCriteriaPersonalAssistantExclusionNumberDescription {
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
