using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemServiceAttributeDefaultGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<BroadworksConnector.Ocip.Models.ServiceAttributeEntryRead> _serviceAttributeEntry;

    [XmlElement(ElementName = "serviceAttributeEntry", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.ServiceAttributeEntryRead> ServiceAttributeEntry {
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
