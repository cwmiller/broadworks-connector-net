using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemGETSSessionPriorityMapGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "sessionPriorityTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable SessionPriorityTable { get; set; }
 }
}
