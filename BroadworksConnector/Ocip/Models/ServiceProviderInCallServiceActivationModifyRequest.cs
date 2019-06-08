using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderInCallServiceActivationModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private string _activationDigits;

    [XmlElement(ElementName = "activationDigits", IsNullable = false, Namespace = "")]
    public string ActivationDigits {
        get => _activationDigits;
        set {
            ActivationDigitsSpecified = true;
            _activationDigits = value;
        }
    }

    [XmlIgnore]
    public bool ActivationDigitsSpecified { get; set; }
}
}
