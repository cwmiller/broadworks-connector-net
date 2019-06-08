using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderServicePackMigrationTaskGetListResponse21 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _taskTable;

    [XmlElement(ElementName = "taskTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable TaskTable {
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
