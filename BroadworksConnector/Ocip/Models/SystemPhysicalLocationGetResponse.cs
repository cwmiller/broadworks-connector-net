using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemPhysicalLocationGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _alwaysAllowEmergencyCalls;

    [XmlElement(ElementName = "alwaysAllowEmergencyCalls", IsNullable = false, Namespace = "")]
    public bool AlwaysAllowEmergencyCalls {
        get => _alwaysAllowEmergencyCalls;
        set {
            AlwaysAllowEmergencyCallsSpecified = true;
            _alwaysAllowEmergencyCalls = value;
        }
    }

    [XmlIgnore]
    public bool AlwaysAllowEmergencyCallsSpecified { get; set; }
}
}
