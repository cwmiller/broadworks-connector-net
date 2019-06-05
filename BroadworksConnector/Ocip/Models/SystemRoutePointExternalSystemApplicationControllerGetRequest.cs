using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemRoutePointExternalSystemApplicationControllerGetRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _externalSystem;

    [XmlElement(ElementName = "externalSystem", IsNullable = false, Namespace = "")]
    public string ExternalSystem {
        get => _externalSystem;
        set {
            ExternalSystemSpecified = true;
            _externalSystem = value;
        }
    }

    [XmlIgnore]
    public bool ExternalSystemSpecified { get; set; }
}
}
