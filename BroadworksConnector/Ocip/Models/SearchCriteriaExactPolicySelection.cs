using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaExactPolicySelection : BroadworksConnector.Ocip.Models.SearchCriteria
{
    private BroadworksConnector.Ocip.Models.EnterpriseVoiceVPNPolicySelection _policySelection;

    [XmlElement(ElementName = "policySelection", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.EnterpriseVoiceVPNPolicySelection PolicySelection {
        get => _policySelection;
        set {
            PolicySelectionSpecified = true;
            _policySelection = value;
        }
    }

    [XmlIgnore]
    public bool PolicySelectionSpecified { get; set; }
}
}
