using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderMWIDeliveryToMobileEndpointModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private List<BroadworksConnector.Ocip.Models.MWIDeliveryToMobileEndpointTemplateActivation> _templateActivation;

    [XmlElement(ElementName = "templateActivation", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.MWIDeliveryToMobileEndpointTemplateActivation> TemplateActivation {
        get => _templateActivation;
        set {
            TemplateActivationSpecified = true;
            _templateActivation = value;
        }
    }

    [XmlIgnore]
    public bool TemplateActivationSpecified { get; set; }
}
}
