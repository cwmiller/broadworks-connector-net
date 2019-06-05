using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAutomaticCollectCallPrefixDigitsDeleteListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private List<BroadworksConnector.Ocip.Models.AutomaticCollectCallPrefixDigitsEntry> _prefixDigitsEntry;

    [XmlElement(ElementName = "prefixDigitsEntry", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.AutomaticCollectCallPrefixDigitsEntry> PrefixDigitsEntry {
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
