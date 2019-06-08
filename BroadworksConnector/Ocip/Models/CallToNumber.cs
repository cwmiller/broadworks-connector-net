using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CallToNumber 
{
    private BroadWorksConnector.Ocip.Models.CallToNumberType _type;

    [XmlElement(ElementName = "type", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CallToNumberType Type {
        get => _type;
        set {
            TypeSpecified = true;
            _type = value;
        }
    }

    [XmlIgnore]
    public bool TypeSpecified { get; set; }
    private string _number;

    [XmlElement(ElementName = "number", IsNullable = false, Namespace = "")]
    public string Number {
        get => _number;
        set {
            NumberSpecified = true;
            _number = value;
        }
    }

    [XmlIgnore]
    public bool NumberSpecified { get; set; }
    private string _extension;

    [XmlElement(ElementName = "extension", IsNullable = false, Namespace = "")]
    public string Extension {
        get => _extension;
        set {
            ExtensionSpecified = true;
            _extension = value;
        }
    }

    [XmlIgnore]
    public bool ExtensionSpecified { get; set; }
}
}
