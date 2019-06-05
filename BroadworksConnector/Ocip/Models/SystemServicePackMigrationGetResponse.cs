using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemServicePackMigrationGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private int _maxSimultaneousMigrationTasks;

    [XmlElement(ElementName = "maxSimultaneousMigrationTasks", IsNullable = false, Namespace = "")]
    public int MaxSimultaneousMigrationTasks {
        get => _maxSimultaneousMigrationTasks;
        set {
            MaxSimultaneousMigrationTasksSpecified = true;
            _maxSimultaneousMigrationTasks = value;
        }
    }

    [XmlIgnore]
    public bool MaxSimultaneousMigrationTasksSpecified { get; set; }
}
}
