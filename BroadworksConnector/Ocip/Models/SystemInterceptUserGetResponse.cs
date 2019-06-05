using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemInterceptUserGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
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
