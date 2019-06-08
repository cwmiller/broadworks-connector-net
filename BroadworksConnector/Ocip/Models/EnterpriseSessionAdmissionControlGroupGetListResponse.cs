using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseSessionAdmissionControlGroupGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _sessionAdmissionControlGroupTable;

    [XmlElement(ElementName = "sessionAdmissionControlGroupTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable SessionAdmissionControlGroupTable {
        get => _sessionAdmissionControlGroupTable;
        set {
            SessionAdmissionControlGroupTableSpecified = true;
            _sessionAdmissionControlGroupTable = value;
        }
    }

    [XmlIgnore]
    public bool SessionAdmissionControlGroupTableSpecified { get; set; }
}
}
