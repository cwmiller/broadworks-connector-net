using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserChargeNumberGetResponse14sp9 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _phoneNumber;

    [XmlElement(ElementName = "phoneNumber", IsNullable = false, Namespace = "")]
    public string PhoneNumber {
        get => _phoneNumber;
        set {
            PhoneNumberSpecified = true;
            _phoneNumber = value;
        }
    }

    [XmlIgnore]
    public bool PhoneNumberSpecified { get; set; }
    private bool _useChargeNumberForEnhancedTranslations;

    [XmlElement(ElementName = "useChargeNumberForEnhancedTranslations", IsNullable = false, Namespace = "")]
    public bool UseChargeNumberForEnhancedTranslations {
        get => _useChargeNumberForEnhancedTranslations;
        set {
            UseChargeNumberForEnhancedTranslationsSpecified = true;
            _useChargeNumberForEnhancedTranslations = value;
        }
    }

    [XmlIgnore]
    public bool UseChargeNumberForEnhancedTranslationsSpecified { get; set; }
    private bool _sendChargeNumberToNetwork;

    [XmlElement(ElementName = "sendChargeNumberToNetwork", IsNullable = false, Namespace = "")]
    public bool SendChargeNumberToNetwork {
        get => _sendChargeNumberToNetwork;
        set {
            SendChargeNumberToNetworkSpecified = true;
            _sendChargeNumberToNetwork = value;
        }
    }

    [XmlIgnore]
    public bool SendChargeNumberToNetworkSpecified { get; set; }
}
}
