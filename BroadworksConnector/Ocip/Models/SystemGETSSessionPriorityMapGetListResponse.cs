using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemGETSSessionPriorityMapGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _sessionPriorityTable;

    [XmlElement(ElementName = "sessionPriorityTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable SessionPriorityTable {
        get => _sessionPriorityTable;
        set {
            SessionPriorityTableSpecified = true;
            _sessionPriorityTable = value;
        }
    }

    [XmlIgnore]
    public bool SessionPriorityTableSpecified { get; set; }
}
}
