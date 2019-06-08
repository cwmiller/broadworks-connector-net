using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemInterceptUserGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
