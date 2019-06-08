using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class MWIDeliveryToMobileEndpointTemplateActivation 
{
    private string _language;

    [XmlElement(ElementName = "language", IsNullable = false, Namespace = "")]
    public string Language {
        get => _language;
        set {
            LanguageSpecified = true;
            _language = value;
        }
    }

    [XmlIgnore]
    public bool LanguageSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.MWIDeliveryToMobileEndpointTemplateType _type;

    [XmlElement(ElementName = "type", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.MWIDeliveryToMobileEndpointTemplateType Type {
        get => _type;
        set {
            TypeSpecified = true;
            _type = value;
        }
    }

    [XmlIgnore]
    public bool TypeSpecified { get; set; }
    private bool _isEnabled;

    [XmlElement(ElementName = "isEnabled", IsNullable = false, Namespace = "")]
    public bool IsEnabled {
        get => _isEnabled;
        set {
            IsEnabledSpecified = true;
            _isEnabled = value;
        }
    }

    [XmlIgnore]
    public bool IsEnabledSpecified { get; set; }
}
}
