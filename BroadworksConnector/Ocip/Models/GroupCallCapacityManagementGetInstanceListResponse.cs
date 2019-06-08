using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCapacityManagementGetInstanceListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _callCapacityGroupTable;

    [XmlElement(ElementName = "callCapacityGroupTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable CallCapacityGroupTable {
        get => _callCapacityGroupTable;
        set {
            CallCapacityGroupTableSpecified = true;
            _callCapacityGroupTable = value;
        }
    }

    [XmlIgnore]
    public bool CallCapacityGroupTableSpecified { get; set; }
}
}
