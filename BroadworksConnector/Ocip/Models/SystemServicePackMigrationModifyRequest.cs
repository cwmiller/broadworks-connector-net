using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemServicePackMigrationModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
