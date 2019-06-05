using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserShInterfaceGetUserIdDataResponse21sp1 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<BroadworksConnector.Ocip.Models.ShInterfaceUserIdDataEntry21sp1> _entry;

    [XmlElement(ElementName = "entry", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.ShInterfaceUserIdDataEntry21sp1> Entry {
        get => _entry;
        set {
            EntrySpecified = true;
            _entry = value;
        }
    }

    [XmlIgnore]
    public bool EntrySpecified { get; set; }
}
}
