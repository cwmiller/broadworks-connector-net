using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderServicePackMigrationTaskGetListResponse21 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "taskTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable TaskTable { get; set; }
 }
}
