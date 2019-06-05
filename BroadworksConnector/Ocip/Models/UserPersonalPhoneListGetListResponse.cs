using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserPersonalPhoneListGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<BroadworksConnector.Ocip.Models.PhoneListEntry> _entry;

    [XmlElement(ElementName = "entry", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.PhoneListEntry> Entry {
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
