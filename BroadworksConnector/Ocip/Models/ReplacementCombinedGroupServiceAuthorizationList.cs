using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementCombinedGroupServiceAuthorizationList 
{
    private List<BroadworksConnector.Ocip.Models.CombinedGroupServiceAuthorization> _groupServiceAuthorization;

    [XmlElement(ElementName = "groupServiceAuthorization", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.CombinedGroupServiceAuthorization> GroupServiceAuthorization {
        get => _groupServiceAuthorization;
        set {
            GroupServiceAuthorizationSpecified = true;
            _groupServiceAuthorization = value;
        }
    }

    [XmlIgnore]
    public bool GroupServiceAuthorizationSpecified { get; set; }
}
}
