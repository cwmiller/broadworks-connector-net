using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupTrunkGroupUserCreationTaskGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _taskTable;

    [XmlElement(ElementName = "taskTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable TaskTable {
        get => _taskTable;
        set {
            TaskTableSpecified = true;
            _taskTable = value;
        }
    }

    [XmlIgnore]
    public bool TaskTableSpecified { get; set; }
}
}
