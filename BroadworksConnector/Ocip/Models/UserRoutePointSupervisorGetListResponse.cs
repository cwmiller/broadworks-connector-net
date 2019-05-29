using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserRoutePointSupervisorGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "supervisorTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable SupervisorTable { get; set; }
 }
}
