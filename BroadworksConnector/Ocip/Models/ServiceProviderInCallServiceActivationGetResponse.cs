using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderInCallServiceActivationGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
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
