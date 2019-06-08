using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaExactHuntPolicy : BroadWorksConnector.Ocip.Models.SearchCriteria
{
    private BroadWorksConnector.Ocip.Models.HuntPolicy _huntPolicy;

    [XmlElement(ElementName = "huntPolicy", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.HuntPolicy HuntPolicy {
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
