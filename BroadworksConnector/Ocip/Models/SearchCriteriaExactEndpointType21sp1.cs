using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaExactEndpointType21sp1 : BroadworksConnector.Ocip.Models.SearchCriteria
{
    private BroadworksConnector.Ocip.Models.EndpointType21sp1 _endpointType;

    [XmlElement(ElementName = "endpointType", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.EndpointType21sp1 EndpointType {
        get => _endpointType;
        set {
            EndpointTypeSpecified = true;
            _endpointType = value;
        }
    }

    [XmlIgnore]
    public bool EndpointTypeSpecified { get; set; }
}
}
