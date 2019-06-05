using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementCustomContactDirectoryEntryList 
{
    private List<BroadworksConnector.Ocip.Models.CustomContactDirectoryEntry> _entry;

    [XmlElement(ElementName = "entry", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.CustomContactDirectoryEntry> Entry {
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
