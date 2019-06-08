using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemServiceAttributeDefaultModifyListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private BroadWorksConnector.Ocip.Models.ServiceCategory _serviceName;

    [XmlElement(ElementName = "serviceName", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ServiceCategory ServiceName {
        get => _serviceName;
        set {
            ServiceNameSpecified = true;
            _serviceName = value;
        }
    }

    [XmlIgnore]
    public bool ServiceNameSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.ServiceAttributeEntry> _serviceAttributeEntry;

    [XmlElement(ElementName = "serviceAttributeEntry", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.ServiceAttributeEntry> ServiceAttributeEntry {
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
