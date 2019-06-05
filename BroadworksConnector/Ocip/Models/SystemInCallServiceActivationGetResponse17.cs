using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemInCallServiceActivationGetResponse17 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _defaultFlashActivationDigits;

    [XmlElement(ElementName = "defaultFlashActivationDigits", IsNullable = false, Namespace = "")]
    public string DefaultFlashActivationDigits {
        get => _defaultFlashActivationDigits;
        set {
            DefaultFlashActivationDigitsSpecified = true;
            _defaultFlashActivationDigits = value;
        }
    }

    [XmlIgnore]
    public bool DefaultFlashActivationDigitsSpecified { get; set; }
    private string _defaultCallTransferActivationDigits;

    [XmlElement(ElementName = "defaultCallTransferActivationDigits", IsNullable = false, Namespace = "")]
    public string DefaultCallTransferActivationDigits {
        get => _defaultCallTransferActivationDigits;
        set {
            DefaultCallTransferActivationDigitsSpecified = true;
            _defaultCallTransferActivationDigits = value;
        }
    }

    [XmlIgnore]
    public bool DefaultCallTransferActivationDigitsSpecified { get; set; }
}
}
