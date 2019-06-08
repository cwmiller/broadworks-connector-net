using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCustomerOriginatedTraceGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
