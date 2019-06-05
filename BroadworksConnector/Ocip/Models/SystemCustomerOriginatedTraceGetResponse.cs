using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCustomerOriginatedTraceGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _screenMaliciousCallers;

    [XmlElement(ElementName = "screenMaliciousCallers", IsNullable = false, Namespace = "")]
    public bool ScreenMaliciousCallers {
        get => _screenMaliciousCallers;
        set {
            ScreenMaliciousCallersSpecified = true;
            _screenMaliciousCallers = value;
        }
    }

    [XmlIgnore]
    public bool ScreenMaliciousCallersSpecified { get; set; }
}
}
