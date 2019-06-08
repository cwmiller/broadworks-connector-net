using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemTreatmentMappingCallBlockingServiceModifyRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private BroadWorksConnector.Ocip.Models.CallBlockingService22 _callBlockingService;

    [XmlElement(ElementName = "callBlockingService", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CallBlockingService22 CallBlockingService {
        get => _callBlockingService;
        set {
            CallBlockingServiceSpecified = true;
            _callBlockingService = value;
        }
    }

    [XmlIgnore]
    public bool CallBlockingServiceSpecified { get; set; }
    private string _treatmentId;

    [XmlElement(ElementName = "treatmentId", IsNullable = false, Namespace = "")]
    public string TreatmentId {
        get => _treatmentId;
        set {
            TreatmentIdSpecified = true;
            _treatmentId = value;
        }
    }

    [XmlIgnore]
    public bool TreatmentIdSpecified { get; set; }
}
}