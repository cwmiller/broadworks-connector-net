using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupTrunkGroupUserCreationTaskAddRequest14sp4UserExtensions 
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
    private List<BroadWorksConnector.Ocip.Models.ExtensionRange17> _extensionRange;

    [XmlElement(ElementName = "extensionRange", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.ExtensionRange17> ExtensionRange {
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
