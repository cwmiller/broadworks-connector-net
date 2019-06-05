using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserPersonalAssistantCallToNumberModifyListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private BroadworksConnector.Ocip.Models.ReplacementCallToNumberList _callToNumberList;

    [XmlElement(ElementName = "callToNumberList", IsNullable = true, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ReplacementCallToNumberList CallToNumberList {
        get => _callToNumberList;
        set {
            CallToNumberListSpecified = true;
            _callToNumberList = value;
        }
    }

    [XmlIgnore]
    public bool CallToNumberListSpecified { get; set; }
}
}
