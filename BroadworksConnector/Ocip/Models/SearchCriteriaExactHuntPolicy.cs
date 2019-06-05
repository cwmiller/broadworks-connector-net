using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaExactHuntPolicy : BroadworksConnector.Ocip.Models.SearchCriteria
{
    private BroadworksConnector.Ocip.Models.HuntPolicy _huntPolicy;

    [XmlElement(ElementName = "huntPolicy", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.HuntPolicy HuntPolicy {
        get => _huntPolicy;
        set {
            HuntPolicySpecified = true;
            _huntPolicy = value;
        }
    }

    [XmlIgnore]
    public bool HuntPolicySpecified { get; set; }
}
}
