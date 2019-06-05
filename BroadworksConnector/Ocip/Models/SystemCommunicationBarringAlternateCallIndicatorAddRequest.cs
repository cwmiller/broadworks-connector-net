using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCommunicationBarringAlternateCallIndicatorAddRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _alternateCallIndicator;

    [XmlElement(ElementName = "alternateCallIndicator", IsNullable = false, Namespace = "")]
    public string AlternateCallIndicator {
        get => _alternateCallIndicator;
        set {
            AlternateCallIndicatorSpecified = true;
            _alternateCallIndicator = value;
        }
    }

    [XmlIgnore]
    public bool AlternateCallIndicatorSpecified { get; set; }
    private string _networkServerAlternateCallIndicator;

    [XmlElement(ElementName = "networkServerAlternateCallIndicator", IsNullable = false, Namespace = "")]
    public string NetworkServerAlternateCallIndicator {
        get => _networkServerAlternateCallIndicator;
        set {
            NetworkServerAlternateCallIndicatorSpecified = true;
            _networkServerAlternateCallIndicator = value;
        }
    }

    [XmlIgnore]
    public bool NetworkServerAlternateCallIndicatorSpecified { get; set; }
}
}
