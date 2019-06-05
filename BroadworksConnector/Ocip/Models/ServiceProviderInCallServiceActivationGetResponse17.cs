using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderInCallServiceActivationGetResponse17 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
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
