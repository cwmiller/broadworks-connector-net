using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAutomaticCollectCallPrefixDigitsDeleteListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private List<BroadWorksConnector.Ocip.Models.AutomaticCollectCallPrefixDigitsEntry> _prefixDigitsEntry;

    [XmlElement(ElementName = "prefixDigitsEntry", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.AutomaticCollectCallPrefixDigitsEntry> PrefixDigitsEntry {
        get => _prefixDigitsEntry;
        set {
            PrefixDigitsEntrySpecified = true;
            _prefixDigitsEntry = value;
        }
    }

    [XmlIgnore]
    public bool PrefixDigitsEntrySpecified { get; set; }
}
}
