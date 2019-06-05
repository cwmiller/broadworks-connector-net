using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupExtensionLengthGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private int _extensionLength;

    [XmlElement(ElementName = "extensionLength", IsNullable = false, Namespace = "")]
    public int ExtensionLength {
        get => _extensionLength;
        set {
            ExtensionLengthSpecified = true;
            _extensionLength = value;
        }
    }

    [XmlIgnore]
    public bool ExtensionLengthSpecified { get; set; }
}
}
