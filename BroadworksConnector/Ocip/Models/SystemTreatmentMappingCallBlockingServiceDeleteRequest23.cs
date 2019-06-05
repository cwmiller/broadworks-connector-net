using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemTreatmentMappingCallBlockingServiceDeleteRequest23 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private BroadworksConnector.Ocip.Models.CallBlockingService23 _callBlockingService;

    [XmlElement(ElementName = "callBlockingService", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CallBlockingService23 CallBlockingService {
        get => _callBlockingService;
        set {
            CallBlockingServiceSpecified = true;
            _callBlockingService = value;
        }
    }

    [XmlIgnore]
    public bool CallBlockingServiceSpecified { get; set; }
}
}
