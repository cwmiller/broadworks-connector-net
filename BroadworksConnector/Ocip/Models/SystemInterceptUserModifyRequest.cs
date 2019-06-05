using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemInterceptUserModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private bool _emergencyAndRepairIntercept;

    [XmlElement(ElementName = "emergencyAndRepairIntercept", IsNullable = false, Namespace = "")]
    public bool EmergencyAndRepairIntercept {
        get => _emergencyAndRepairIntercept;
        set {
            EmergencyAndRepairInterceptSpecified = true;
            _emergencyAndRepairIntercept = value;
        }
    }

    [XmlIgnore]
    public bool EmergencyAndRepairInterceptSpecified { get; set; }
}
}
