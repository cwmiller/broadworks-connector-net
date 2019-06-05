using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaExactCallCenterType : BroadworksConnector.Ocip.Models.SearchCriteria
{
    private BroadworksConnector.Ocip.Models.CallCenterType _callCenterType;

    [XmlElement(ElementName = "callCenterType", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CallCenterType CallCenterType {
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
