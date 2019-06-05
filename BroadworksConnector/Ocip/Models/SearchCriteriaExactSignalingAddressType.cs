using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaExactSignalingAddressType : BroadworksConnector.Ocip.Models.SearchCriteria
{
    private BroadworksConnector.Ocip.Models.SignalingAddressType _profile;

    [XmlElement(ElementName = "profile", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SignalingAddressType Profile {
        get => _profile;
        set {
            ProfileSpecified = true;
            _profile = value;
        }
    }

    [XmlIgnore]
    public bool ProfileSpecified { get; set; }
}
}
