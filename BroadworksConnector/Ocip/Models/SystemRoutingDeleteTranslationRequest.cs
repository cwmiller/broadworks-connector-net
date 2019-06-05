using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemRoutingDeleteTranslationRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _digits;

    [XmlElement(ElementName = "digits", IsNullable = false, Namespace = "")]
    public string Digits {
        get => _digits;
        set {
            DigitsSpecified = true;
            _digits = value;
        }
    }

    [XmlIgnore]
    public bool DigitsSpecified { get; set; }
}
}
