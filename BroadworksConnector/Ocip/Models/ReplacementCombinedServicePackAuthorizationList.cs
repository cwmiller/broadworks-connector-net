using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementCombinedServicePackAuthorizationList 
{
    private List<BroadworksConnector.Ocip.Models.CombinedServicePackAuthorization> _servicePackAuthorization;

    [XmlElement(ElementName = "servicePackAuthorization", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.CombinedServicePackAuthorization> ServicePackAuthorization {
        get => _servicePackAuthorization;
        set {
            ServicePackAuthorizationSpecified = true;
            _servicePackAuthorization = value;
        }
    }

    [XmlIgnore]
    public bool ServicePackAuthorizationSpecified { get; set; }
}
}
