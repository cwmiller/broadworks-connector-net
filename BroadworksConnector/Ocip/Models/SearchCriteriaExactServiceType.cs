using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaExactServiceType : BroadworksConnector.Ocip.Models.SearchCriteria
{
    private BroadworksConnector.Ocip.Models.ServiceType _serviceType;

    [XmlElement(ElementName = "serviceType", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ServiceType ServiceType {
        get => _serviceType;
        set {
            ServiceTypeSpecified = true;
            _serviceType = value;
        }
    }

    [XmlIgnore]
    public bool ServiceTypeSpecified { get; set; }
}
}
