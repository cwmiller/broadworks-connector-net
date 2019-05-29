using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemServicePackMigrationModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "maxSimultaneousMigrationTasks", IsNullable = false)]
    public int MaxSimultaneousMigrationTasks { get; set; }
 }
}
