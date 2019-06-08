using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupTrunkGroupUserCreationTaskAddRequestUserExtensions 
{
    private List<string> _extension;

    [XmlElement(ElementName = "extension", IsNullable = false, Namespace = "")]
    public List<string> Extension {
        get => _extension;
        set {
            ExtensionSpecified = true;
            _extension = value;
        }
    }

    [XmlIgnore]
    public bool ExtensionSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.ExtensionRange> _extensionRange;

    [XmlElement(ElementName = "extensionRange", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.ExtensionRange> ExtensionRange {
        get => _extensionRange;
        set {
            ExtensionRangeSpecified = true;
            _extensionRange = value;
        }
    }

    [XmlIgnore]
    public bool ExtensionRangeSpecified { get; set; }
}
}
