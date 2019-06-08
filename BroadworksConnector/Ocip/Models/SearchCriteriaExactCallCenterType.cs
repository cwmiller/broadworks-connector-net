using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaExactCallCenterType : BroadWorksConnector.Ocip.Models.SearchCriteria
{
    private BroadWorksConnector.Ocip.Models.CallCenterType _callCenterType;

    [XmlElement(ElementName = "callCenterType", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CallCenterType CallCenterType {
        get => _callCenterType;
        set {
            CallCenterTypeSpecified = true;
            _callCenterType = value;
        }
    }

    [XmlIgnore]
    public bool CallCenterTypeSpecified { get; set; }
}
}
