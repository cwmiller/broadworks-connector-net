using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SecurityClassificationCustomizationActivation 
{
    private string _name;

    [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
    public string Name {
        get => _name;
        set {
            NameSpecified = true;
            _name = value;
        }
    }

    [XmlIgnore]
    public bool NameSpecified { get; set; }
    private bool _isCustomized;

    [XmlElement(ElementName = "isCustomized", IsNullable = false, Namespace = "")]
    public bool IsCustomized {
        get => _isCustomized;
        set {
            IsCustomizedSpecified = true;
            _isCustomized = value;
        }
    }

    [XmlIgnore]
    public bool IsCustomizedSpecified { get; set; }
}
}
