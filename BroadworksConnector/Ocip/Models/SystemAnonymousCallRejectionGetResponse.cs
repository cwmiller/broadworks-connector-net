using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAnonymousCallRejectionGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _paiRequired;

    [XmlElement(ElementName = "paiRequired", IsNullable = false, Namespace = "")]
    public bool PaiRequired {
        get => _paiRequired;
        set {
            PaiRequiredSpecified = true;
            _paiRequired = value;
        }
    }

    [XmlIgnore]
    public bool PaiRequiredSpecified { get; set; }
    private bool _screenOnlyLocalCalls;

    [XmlElement(ElementName = "screenOnlyLocalCalls", IsNullable = false, Namespace = "")]
    public bool ScreenOnlyLocalCalls {
        get => _screenOnlyLocalCalls;
        set {
            ScreenOnlyLocalCallsSpecified = true;
            _screenOnlyLocalCalls = value;
        }
    }

    [XmlIgnore]
    public bool ScreenOnlyLocalCallsSpecified { get; set; }
}
}
