using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemServiceAttributeDefaultGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<BroadWorksConnector.Ocip.Models.ServiceAttributeEntryRead> _serviceAttributeEntry;

    [XmlElement(ElementName = "serviceAttributeEntry", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.ServiceAttributeEntryRead> ServiceAttributeEntry {
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
