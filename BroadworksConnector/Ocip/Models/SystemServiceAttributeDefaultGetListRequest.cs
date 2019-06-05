using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemServiceAttributeDefaultGetListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private BroadworksConnector.Ocip.Models.ServiceCategory _serviceName;

    [XmlElement(ElementName = "serviceName", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ServiceCategory ServiceName {
        get => _serviceName;
        set {
            ServiceNameSpecified = true;
            _serviceName = value;
        }
    }

    [XmlIgnore]
    public bool ServiceNameSpecified { get; set; }
}
}
