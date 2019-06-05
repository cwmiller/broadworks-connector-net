using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemServiceAttributeDefaultModifyListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private List<BroadworksConnector.Ocip.Models.ServiceAttributeEntry> _serviceAttributeEntry;

    [XmlElement(ElementName = "serviceAttributeEntry", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.ServiceAttributeEntry> ServiceAttributeEntry {
        get => _serviceAttributeEntry;
        set {
            ServiceAttributeEntrySpecified = true;
            _serviceAttributeEntry = value;
        }
    }

    [XmlIgnore]
    public bool ServiceAttributeEntrySpecified { get; set; }
}
}
