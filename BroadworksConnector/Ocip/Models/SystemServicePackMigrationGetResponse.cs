using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemServicePackMigrationGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "maxSimultaneousMigrationTasks", IsNullable = false)]
    public int MaxSimultaneousMigrationTasks { get; set; }
 }
}
