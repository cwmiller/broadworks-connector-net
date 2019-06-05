using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderMWIDeliveryToMobileEndpointCustomTemplateAddRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceProviderId;

    [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
    public string ServiceProviderId {
        get => _serviceProviderId;
        set {
            ServiceProviderIdSpecified = true;
            _serviceProviderId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderIdSpecified { get; set; }
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
    private BroadworksConnector.Ocip.Models.MWIDeliveryToMobileEndpointTemplateType _type;

    [XmlElement(ElementName = "type", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.MWIDeliveryToMobileEndpointTemplateType Type {
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
    private BroadworksConnector.Ocip.Models.MWIDeliveryToMobileEndpointTemplateBody _templateBody;

    [XmlElement(ElementName = "templateBody", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.MWIDeliveryToMobileEndpointTemplateBody TemplateBody {
        get => _templateBody;
        set {
            TemplateBodySpecified = true;
            _templateBody = value;
        }
    }

    [XmlIgnore]
    public bool TemplateBodySpecified { get; set; }
}
}
