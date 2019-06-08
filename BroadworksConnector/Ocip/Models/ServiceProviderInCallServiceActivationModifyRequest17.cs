using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderInCallServiceActivationModifyRequest17 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private string _flashActivationDigits;

    [XmlElement(ElementName = "flashActivationDigits", IsNullable = false, Namespace = "")]
    public string FlashActivationDigits {
        get => _flashActivationDigits;
        set {
            FlashActivationDigitsSpecified = true;
            _flashActivationDigits = value;
        }
    }

    [XmlIgnore]
    public bool FlashActivationDigitsSpecified { get; set; }
    private string _callTransferActivationDigits;

    [XmlElement(ElementName = "callTransferActivationDigits", IsNullable = false, Namespace = "")]
    public string CallTransferActivationDigits {
        get => _callTransferActivationDigits;
        set {
            CallTransferActivationDigitsSpecified = true;
            _callTransferActivationDigits = value;
        }
    }

    [XmlIgnore]
    public bool CallTransferActivationDigitsSpecified { get; set; }
}
}
